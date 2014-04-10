#include <QCoreApplication>
#include <QtCore/QDebug>
#include "stackref.h"
#include "stackarray.h"
#include "stackinterface.h"

void Calculator(stackInterface *stack, char *line)
{
    int mainResult = 0;
        for (int i = 0; line[i] != '\0'; i++)
        {
            char symbol = line[i];
            if (symbol != '-' && symbol != '*' && symbol != '/' && symbol != '+' && symbol != ' ')
            {
                stack->Push(atoi(&symbol));
            }
            else switch (symbol)
            {
                case '+':
                {
                    int result = 0;
                    result += stack->Top();
                    stack->Pop();
                    result += stack->Top();
                    stack->Pop();
                    stack->Push(result);
                    break;
                }
                case '-':
                {
                    int result = 0;
                    result -= stack->Top();
                    stack->Pop();
                    result += stack->Top();
                    stack->Pop();
                    stack->Push(result);
                    break;
                }
                case '*':
                {
                    int result = 0;
                    result = 1;
                    result *= stack->Top();
                    stack->Pop();
                    result *= stack->Top();
                    stack->Pop();
                    stack->Push(result);
                    break;
                }
                case '/':
                {
                    int tempor = stack->Top();
                    stack->Pop();
                    if (tempor != 0)
                    {
                        int result = 0;
                        result = stack->Top() / tempor;
                        stack->Pop();
                        stack->Push(result);
                        break;
                    }
                    else
                    {
                        printf("Error: fuuu!! there is a zero in division!!!\n");
                        mainResult = -99999;
                        break;
                    }
                }
                default:
                {
                    continue;
                }
            }
        }
        mainResult = stack->Top();
        stack->Pop();
        if (mainResult != -99999)
        {
            qDebug() << "Result: " << mainResult;
        }
}

int main(int argc, char *argv[])
{
    //StackRef stack;
    StackArray stack;
//    stack.Push(5);
//    stack.Push(9);
//    stack.Push(6);
//    stack.Pop();
//    qDebug() << stack.Top();

    Calculator(&stack, "21+");
    stack.ClearStack();
    return 0;
}
