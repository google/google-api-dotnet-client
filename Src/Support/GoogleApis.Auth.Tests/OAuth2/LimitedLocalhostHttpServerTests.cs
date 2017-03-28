﻿/*
Copyright 2017 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Auth.OAuth2.LocalServerCodeReceiver.LimitedLocalhostHttpServer;

namespace Google.Apis.Auth.OAuth2
{
    [TestFixture]
    class LimitedLocalhostHttpServerTests
    {
        private LocalServerCodeReceiver.LimitedLocalhostHttpServer StartServer()
        {
            var url = string.Format(LocalServerCodeReceiver.LoopbackCallback, 0);
            return LocalServerCodeReceiver.LimitedLocalhostHttpServer.Start(url);
        }

        [Test]
        public void AutoPortAssignment()
        {
            using (var server = StartServer())
            {
                Assert.That(server.Port, Is.Not.EqualTo(0));
            }
        }

        [Test]
        public async Task ValidRequest()
        {
            using (var server = StartServer())
            using (var client = new HttpClient())
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                var url = string.Format(LocalServerCodeReceiver.LoopbackCallback, server.Port) + "?a=b&c=d";
                var responseMsgTask = client.GetAsync(url, cts.Token);

                var queryParams = await server.GetQueryParamsAsync(cts.Token);

                var responseMsg = await responseMsgTask;
                var responseBody = await responseMsg.Content.ReadAsStringAsync();

                Assert.That(responseBody, Is.EqualTo(LocalServerCodeReceiver.ClosePageResponse));
                Assert.That(queryParams, Is.EqualTo(new Dictionary<string, string> { { "a", "b" }, { "c", "d" } }));
            }
        }

        [Test]
        public async Task ValidRequestNoQueryParams()
        {
            using (var server = StartServer())
            using (var client = new HttpClient())
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                var url = string.Format(LocalServerCodeReceiver.LoopbackCallback, server.Port);
                var responseMsgTask = client.GetAsync(url, cts.Token);

                var queryParams = await server.GetQueryParamsAsync(cts.Token);

                var responseMsg = await responseMsgTask;
                var responseBody = await responseMsg.Content.ReadAsStringAsync();

                Assert.That(responseBody, Is.EqualTo(LocalServerCodeReceiver.ClosePageResponse));
                Assert.That(queryParams, Is.Empty);
            }
        }

        [Test]
        public void InvalidRequestUrl()
        {
            using (var server = StartServer())
            using (var client = new HttpClient())
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                var url = $"http://localhost:{server.Port}/WRONG/?a=b&c=d";
                var responseMsgTask = client.GetAsync(url, cts.Token);

                Assert.That(() => server.GetQueryParamsAsync(cts.Token),
                    Throws.TypeOf<ServerException>().With.Message.Contains("Expected request path to start"));
            }
        }

        [Test]
        public async Task InvalidRequestLine()
        {
            using (var server = StartServer())
            using (var client = new TcpClient())
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                await client.ConnectAsync("localhost", server.Port);
                var stream = client.GetStream();
                var httpRequest = Encoding.ASCII.GetBytes("INVALIDREQUESTLINE\r\n");
                var dummyTask = stream.WriteAsync(httpRequest, 0, httpRequest.Length);

                Assert.That(() => server.GetQueryParamsAsync(cts.Token),
                    Throws.TypeOf<ServerException>().With.Message.Contains("Request line ill-formatted."));
            }
        }

        [Test]
        public async Task InvalidRequestLineTooLong()
        {
            using (var server = StartServer())
            using (var client = new TcpClient())
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                await client.ConnectAsync("localhost", server.Port);
                var stream = client.GetStream();
                var httpRequest = Encoding.ASCII.GetBytes(new string('X', 1000));
                var dummyTask = stream.WriteAsync(httpRequest, 0, httpRequest.Length);

                Assert.That(() => server.GetQueryParamsAsync(cts.Token),
                    Throws.TypeOf<ServerException>().With.Message.Contains("Request line too long:"));
            }
        }

        [Test]
        public void InvalidRequestTooManyHeaders()
        {
            using (var server = StartServer())
            using (var client = new HttpClient())
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                var url = string.Format(LocalServerCodeReceiver.LoopbackCallback, server.Port);
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("X-Test", new string('X', 10000));
                client.SendAsync(request, cts.Token);

                Assert.That(() => server.GetQueryParamsAsync(cts.Token),
                    Throws.TypeOf<ServerException>().With.Message.Contains("Headers too long:"));
            }
        }


    }
}
