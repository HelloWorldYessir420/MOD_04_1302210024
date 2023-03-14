using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD_04_1302210024
{
    internal class PosisiKarakterGame
    {
        public enum GerakanState
        {
            Jongkok, Tengkurap, Berdiri, Terbang
        }
        private readonly Action[] _stateaction;
        public GerakanState currentState { get; private set; }

        public PosisiKarakterGame()
        {
            _stateaction = new Action[] {TombolW, TombolS};
            currentState = GerakanState.Berdiri;
            _stateaction[(int)currentState]();
        }
        
        public void Tengkurap()
        {
            currentState = GerakanState.Tengkurap;
            _stateaction[(int)currentState]();
        }

        public void Jongkok()
        {
            currentState = GerakanState.Jongkok;
            _stateaction[(int)currentState]();
        }

        public void Berdiri()
        {
            currentState = GerakanState.Berdiri;
            _stateaction[(int)currentState]();
        }

        public void Terbang()
        {
            currentState = GerakanState.Terbang;
            _stateaction[(int)currentState]();
        }

        private void TombolW()
        {
            Console.WriteLine("Tombol arah bawah ditekan");
        }

        private void TombolS()
        {
            Console.WriteLine("Tombol arah atas ditekan");
        }


    }
}
