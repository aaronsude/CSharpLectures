using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Async
{
    public class DownloadManager
    {
        /// <summary>
        /// Runs both sequential and parallel simulations to compare results.
        /// </summary>
        public async Task RunSimulationAsync()
        {
            Console.WriteLine("===== PARALLEL DOWNLOAD SIMULATION =====");
            Console.WriteLine();

            // 1. Sequential Run
            await RunSequentialSimulation();

            // 2. Parallel Run
            await RunParallelSimulation();
        }

        private async Task RunSequentialSimulation()
        {
            Console.WriteLine("Sequential (one after another):");
            Console.WriteLine("──────────────────────────");

            Stopwatch timer = Stopwatch.StartNew();

            await DownloadFileAsync("File 1", 5);
            await DownloadFileAsync("File 2", 10);
            await DownloadFileAsync("File 3", 6);

            timer.Stop();
            Console.WriteLine($"Total: {timer.Elapsed.Seconds} seconds");
            Console.WriteLine();
        }

        private async Task RunParallelSimulation()
        {
            Console.WriteLine("Parallel (simultaneously):");
            Console.WriteLine("──────────────────────");

            Stopwatch timer = Stopwatch.StartNew();

            // Start all tasks simultaneously
            Task t1 = DownloadFileAsync("File 1", 5);
            Task t2 = DownloadFileAsync("File 2", 10);
            Task t3 = DownloadFileAsync("File 3", 6);

            // Wait for all to complete concurrently
            await Task.WhenAll(t1, t2, t3);

            timer.Stop();
            Console.WriteLine($"Total: {timer.Elapsed.Seconds} seconds (faster!)");
        }

        /// <summary>
        /// Logic for an individual download simulation.
        /// </summary>
        private async Task DownloadFileAsync(string name, int seconds)
        {
            Console.WriteLine($"{name} is being downloaded...");
            await Task.Delay(seconds * 1000);
            Console.WriteLine($"{name} finished! ({seconds} seconds)");
        }}
    }
