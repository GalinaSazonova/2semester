#pragma once
#ifndef STACKINTERFACE_H
#define STACKINTERFACE_H

/// Interface for stack with main functions.
class stackInterface
{
public:
    stackInterface();
    // Push value to a stack.
    virtual void Push(int value) = 0;
    // Returns head value.
    virtual int Top() = 0;
    virtual void Pop() = 0;
    // Check if stack is empty.
    virtual bool IsEmpty() = 0;
    // Makes stack empty.
    virtual void ClearStack() = 0;
};

#endif // STACKINTERFACE_H
