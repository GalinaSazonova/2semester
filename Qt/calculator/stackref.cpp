#include "stackref.h"

using namespace std;

StackRef::StackRef()
    : head(nullptr)
{
}

void StackRef::Push(int value)
{
    StackElement *newElem = new StackElement;
    newElem->value = value;
    newElem->next = this->head;
    this->head = newElem;
}

int StackRef::Top()
{
    return this->head->value;
}

void StackRef::Pop()
{
    StackElement *temp = this->head;
    this->head = this->head->next;
    delete temp;
}

bool StackRef::IsEmpty()
{
    return this->head != nullptr;
}

void StackRef::ClearStack()
{
    StackElement *temp = this->head;
    while (temp != nullptr)
    {
        StackElement *toDelete = temp;
        temp = temp->next;
        delete toDelete;
    }
}


