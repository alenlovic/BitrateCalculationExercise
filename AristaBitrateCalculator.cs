using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace BitrateCalculationExercise
{
    public static class AristaBitrateCalculator
    {
        static void Main(string[] args)
        {

            string jsonData = @"{
                ""Device"": ""Arista"",
                ""Model"": ""X-Video"",
                ""NIC"": [{
                    ""Description"": ""Linksys ABR"",
                    ""MAC"": ""14:91:82:3C:D6:7D"",
                    ""Timestamp"": ""2020-03-23T18:25:43.511Z"",
                    ""Rx"": ""3698574500"",
                    ""Tx"": ""122558800""
                }]
            }";

            var aristaDevice = JsonSerializer.Deserialize<AristaDevice>(jsonData);

            const int pollingRate = 2; //Hz
            var rxBitrate = long.Parse(aristaDevice.NIC[0].Rx) * 8 / pollingRate;
            var txBitrate = long.Parse(aristaDevice.NIC[0].Tx) * 8 / pollingRate;

            Console.WriteLine($"Rx bitrate: {rxBitrate:N0} bps");
            Console.WriteLine($"Tx bitrate: {txBitrate:N0} bps");

            Console.ReadLine();
        }
    }

}
