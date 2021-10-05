using System;
namespace PracticeExercise1
{
    public class ArrayList : IList
    {
        private int[] array = null;
        private int count = 0;

        public ArrayList()
        {
            array = new int[16];
        }

        public int Length => count;

        public bool IsEmpty => count == 0;

        public int First
        {
            get
            {
                if (IsEmpty == false)
                {
                    return array[0];
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        public int Last
        {
            get
            {
                if (IsEmpty == false)
                {
                    return array[count-1];
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }


        public void Append(int i)
        {
            if (count == array.Length)
            {
                Resize();
            }

            array[count] = i;
            count++;
        }

        private void Resize()
        {
            Array.Resize(ref array, array.Length * 2);
        }

        public void InsertAfter(int newValue, int existingValue)
        {
            if (count == array.Length)
            {
                Resize();
            }

            int indexOfExistingValue = FirstIndexOf(existingValue);

            if (indexOfExistingValue == -1)
            {
                Append(newValue);
            }
            else
            {
                // shift everything from that index to the right
                ShiftRight(indexOfExistingValue+1);

                // add new value at that index
                array[indexOfExistingValue+1] = newValue;
                count++;
            }

        }

        public void InsertAt(int newValue, int index)
        {
            if (count == array.Length)
            {
                Resize();
            }
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                ShiftRight(index);
                array[index] = newValue;
                count++;
            }
        }

        public void Remove(int value)
        {
            int indexOfValue = FirstIndexOf(value);
            if (indexOfValue != -1)
            {
                ShiftLeft(indexOfValue);
                count--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                ShiftLeft(index);
                count--;
            }
        }

        public int FirstIndexOf(int existingValue)
        {
            // find index of existing value
            for (int i = 0; i < count; i++)
            {
                if (array[i] == existingValue)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Prepend(int i)
        {
            if (count == array.Length)
            {
                Resize();
            }

            ShiftRight(0);
            array[0] = i;
            count++;
        }

        private void ShiftRight(int startingIndex)
        {
            if (count == array.Length)
            {
                Resize();
            }

            for (int i = count; i > startingIndex; i--)
            {
                array[i] = array[i - 1];
            }
        }

        // TODO
        private void ShiftLeft(int endingIndex)
        {
            if (count == array.Length)
            {
                Resize();
            }

            for (int i = endingIndex + 1; i < count; i++)
            {
                array[i - 1] = array[i];
            }
        }

        public override string ToString()
        {
            string result = "[";
            if (count == 0)
            {
                result += "]";
            }
            else
            {
                for (int i = 0; i < count - 1; i++)
                {
                    result += array[i] + ", ";
                }

                result += array[count - 1] + "]";
            }
            return result;

            //return "[" + string.Join(", ", array) + "]";

        }


        public void Clear()
        {
            count = 0;
        }

        public IList Reverse()
        {
            var reversedList = new ArrayList();
                //new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                if (reversedList.count == reversedList.array.Length)
                {
                    Array.Resize(ref reversedList.array, reversedList.array.Length * 2);
                }
                reversedList.Append(array[i]);
            }
            return reversedList;
        }
    }
}
