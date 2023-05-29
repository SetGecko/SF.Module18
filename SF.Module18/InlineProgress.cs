using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Module18
{
    internal class InlineProgress : IProgress<double>, IDisposable
    {
        private readonly int _posX;
        private readonly int _posY;

        public InlineProgress()
        {
            _posX = Console.CursorLeft;
            _posY = Console.CursorTop;
        }

        public void Report(double progress)
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.WriteLine($"{progress:P0}");
        }

        public void Dispose()
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.WriteLine("Готово!\r\n");
        }
    }
}
