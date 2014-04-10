#ifndef STACKREF_H
#pragma once
#define STACKREF_H
#include "stackinterface.h"

/// Stack based on references.
class StackRef : public stackInterface
{
public:
    StackRef();
    struct StackElement
    {
        char value;
        StackElement *next;
    };
    void Push(int value) override;
    int Top() override;
    void Pop() override;
    bool IsEmpty() override;
    void ClearStack() override;
private:
    StackElement *head;
};

#endif // STACKREF_H
