namespace StackCalcul
{
    interface StackInterface
    {
        void Push(int value);
        int Pop();
        bool IsEmpty();
        void PrintStack();
        void ClearStack();
    }
}
