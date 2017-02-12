using System;
using Rozifus.SequenceFun.Interfaces;

namespace Rozifus.SequenceFun.IntSequences
{
    public class IntegerSequencer : ISequencer<int> 
    {
        public static int Zero = 0;
        int _value;

        public IntegerSequencer(int initial) {
            Value = initial;            
        }

        public IntegerSequencer() {
            Value = Zero;
        }

        public int Value {
            get {
                return _value;
            }
            set {
                _value = value;
            }
        }

        public ISequencer<int> Next() {
            return new IntegerSequencer(Value + 1);
        }

        public ISequencer<int> Prev() {
            return new IntegerSequencer(Value - 1);
        }

        public override string ToString() {
            return Value.ToString();
        }
    }
}
