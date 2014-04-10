#include "stackarray.h"

StackArray::StackArray(): length(0), mas(new int[100])
{
}

void StackArray::Push(int value)
{
    mas[length] = value;
    length++;
}

int StackArray::Top()
{
    if (length <= 0)
            return -1;
    return mas[length - 1];
}

void StackArray::Pop()
{
    length--;
}

bool StackArray::IsEmpty()
{
    return (length < 0);
}

void StackArray::ClearStack()
{
    delete mas;
}
