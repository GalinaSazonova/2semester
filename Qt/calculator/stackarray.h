#pragma once
#ifndef STACKARRAY_H
#define STACKARRAY_H
#include "stackinterface.h"

/// Stack based on array
class StackArray : public stackInterface
{
public:
    StackArray();

    void Push(int value) override;
    int Top() override;
    void Pop() override;
    bool IsEmpty() override;
    void ClearStack() override;

private:
    int *mas;
    int length;
};

#endif // STACKARRAY_H
