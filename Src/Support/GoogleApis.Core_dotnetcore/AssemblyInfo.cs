using System.Runtime.CompilerServices;

#if SIGNED
[assembly: InternalsVisibleTo("IntegrationTests_NetCore,PublicKey=00240000048000009400000006020000002400005253413100040000010001003d69fa08add2ea7341cc102edb2f3a59bb49e7f7c8bf1bd96d494013c194f4d80ee30278f20e08a0b7cb863d6522d8c1c0071dd36748297deefeb99e899e6a80b9ddc490e88ea566d2f7d4f442211f7beb6b2387fb435bfaa3ecfe7afc0184cc46f80a5866e6bb8eb73f64a3964ed82f6a5036b91b1ac93e1f44508b65e51fce")]
#else
[assembly: InternalsVisibleTo("IntegrationTests_NetCore")]
#endif