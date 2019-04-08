using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CircularBuffer
    {
        private const int bufferSize = 3;
        private  char[] _buffer = new char[bufferSize];
        private int variable = 0;

        public bool Push(char input)
        {
            if (variable >= bufferSize)
            {
                return false;
            }
            else
            {
                _buffer[variable] = input;
                variable++;
                
                return true;
            }

        }

        public void WriteBuffer()
        {
            foreach (var something in _buffer)
            {
                Console.WriteLine(something);
            }
        }

        public bool ForcePush(char data)
        {
            _buffer[variable%bufferSize] = data;
            variable++;
            return true;
        }

        public char Pop()
        {
            if (variable != 0)
            {
                variable--;
                variable = variable % bufferSize;
            }
            char result = _buffer[variable % bufferSize];
            _buffer[variable % bufferSize] =' ';
          
            return result;

        }
    }
}
