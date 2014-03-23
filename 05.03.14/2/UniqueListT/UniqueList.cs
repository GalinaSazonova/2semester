using ListT;

namespace UniqueListT
{
    /// <summary>
    /// Unique list, there is no any meaning meeting twice
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UniqueList<T> : ListT<T>
    {
        /// <summary>
        /// Changed method Tnsert to Head.
        /// </summary>
        /// <param name="value"></param>
        public override void InsertToHead(T value)
        {
            if (this.Contains(value))
            {
                throw new ExeptionAlreadyExist();
            }
            else
            {
                base.InsertToHead(value);
            }
        }

        /// <summary>
        /// Changed method Insrt to tail.
        /// </summary>
        /// <param name="value"></param>
        public override void InsertToTail(T value)
        {
            if (this.Contains(value))
            {
                throw new ExeptionAlreadyExist();
            }
            else
            {
                base.InsertToTail(value);
            }
        }

        /// <summary>
        /// Changed method InsertByPosition.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        public override void InsertElementByPosition(T value, int position)
        {
            if (this.Contains(value))
            {
                throw new ExeptionAlreadyExist();
            }
            else
            {
                base.InsertElementByPosition(value, position);
            }
        }

        /// <summary>
        /// New remove
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            if (!this.Contains(value))
            {
                throw new ExeptionDeleteWrong();
            }
            else
            {
                base.Remove(this.FindPosition(value));
            }
        }
    }
}
