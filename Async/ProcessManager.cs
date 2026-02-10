using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Async
{
    public class Process
    {
        public string Name { get; set; }
        public int DurationMs { get; set; }
        public bool Success { get; private set; }
        public string ErrorMessage { get; private set; } = string.Empty;

        public Process(string name, int durationMs)
        {
            Name = name;
            DurationMs = durationMs;
        }

        /// <summary>
        /// Executes the process and handles its internal success/failure logic.
        /// </summary>
        public async Task ExecuteAsync()
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {Name} started (Duration: {DurationMs / 1000.0}s)");

            try
            {
                await Task.Delay(DurationMs);

                // Simulate an error specifically for Process C
                if (Name == "Process C")
                {
                    throw new Exception("Connection failed");
                }

                Success = true;
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {Name} completed");
            }
            catch (Exception ex)
            {
                Success = false;
                ErrorMessage = ex.Message;
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {Name} ERROR! ({ErrorMessage})");
            }
        }

        public string GetStatus()
        {
            return $"{Name}: {(Success ? "Success" : "X Error")}";
        }
       
    }

    public class ProcessManager
    {
        private List<Process> _processes;

        public ProcessManager()
        {
            _processes = CreateProcesses();
        }

        public async Task RunAllAsync()
        {
            Console.WriteLine("Starting processes:");
            Console.WriteLine("─────────────────");

            Stopwatch timer = Stopwatch.StartNew();

            // Execute using Task.WhenAll for true parallelism
            await Task.WhenAll(_processes.Select(p => p.ExecuteAsync()));

            timer.Stop();
            PrintResults(timer.Elapsed.Seconds);
        }

        private List<Process> CreateProcesses()
        {
            return new List<Process>
            {
                new Process("Process C", 1000),
                new Process("Process A", 3000),
                new Process("Process B", 2000),
                new Process("Process C", 5000)
            };
        }

        private void PrintResults(int totalSeconds)
        {
            Console.WriteLine("\nSummary:");
            Console.WriteLine("────────────────");
            Console.WriteLine($"Total Duration: {totalSeconds} seconds");

            var failed = _processes.Where(p => !p.Success);
            foreach (Process process in failed)
            {
               Console.WriteLine($"Error in {process.Name}: {process.ErrorMessage}");
            }
            if(failed.Count() == 0)
            {
                Console.WriteLine("All processes completed successfully!");
            }

            Console.WriteLine("\nStatus after execution:");
            foreach (var p in _processes)
            {
                Console.WriteLine(p.GetStatus());
            }
        }
    }
}
