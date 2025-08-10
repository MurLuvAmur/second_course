#include <iostream>

struct Node {
    int data;
    Node* next;
};

// Класс для реализации стека
class Stack {
private:
    Node* top;

public:
    Stack() : top(nullptr) {}

    // Добавление элемента в стек
    void push(int value) {
        Node* newNode = new Node{ value, top };
        top = newNode;
    }

    // Удаление элемента из стека
    void pop() {
        if (top == nullptr) {
            std::cout << "Stack is empty." << std::endl;
            return;
        }
        Node* temp = top;
        top = top->next;
        delete temp;
    }

    // Очистка стека
    void clear() {
        while (top != nullptr) {
            pop();
        }
    }

    // Отображение элементов стека в прямом порядке
    void display() {
        Node* current = top;
        while (current != nullptr) {
            std::cout << current->data << " ";
            current = current->next;
        }
        std::cout << std::endl;
    }

    // Удаление элементов, кратных 7, с использованием вспомогательного стека
    void removeMultiplesOf7() {
        Stack tempStack;
        while (top != nullptr) {
            if (top->data % 7 != 0) {
                tempStack.push(top->data);
            }
            pop();
        }
        // Перекладываем обратно в оригинальный стек
        while (tempStack.top != nullptr) {
            push(tempStack.top->data);
            tempStack.pop();
        }
    }

    ~Stack() {
        clear();
    }
};

// Класс для реализации очереди
class Queue {
private:
    Node* front;
    Node* rear;

public:
    Queue() : front(nullptr), rear(nullptr) {}

    // Добавление элемента в очередь
    void enqueue(int value) {
        Node* newNode = new Node{ value, nullptr };
        if (rear != nullptr) {
            rear->next = newNode;
        }
        rear = newNode;
        if (front == nullptr) {
            front = newNode;
        }
    }

    // Удаление элемента из очереди
    void dequeue() {
        if (front == nullptr) {
            std::cout << "Queue is empty." << std::endl;
            return;
        }
        Node* temp = front;
        front = front->next;
        if (front == nullptr) {
            rear = nullptr;
        }
        delete temp;
    }

    // Очистка очереди
    void clear() {
        while (front != nullptr) {
            dequeue();
        }
    }

    // Отображение элементов очереди в прямом порядке
    void display() const {
        Node* current = front;
        while (current != nullptr) {
            std::cout << current->data << " ";
            current = current->next;
        }
        std::cout << std::endl;
    }

    // Удаление элементов, кратных 7, с использованием вспомогательной очереди
    void removeMultiplesOf7() {
        Queue tempQueue;
        while (front != nullptr) {
            if (front->data % 7 != 0) {
                tempQueue.enqueue(front->data);
            }
            dequeue();
        }
        // Перекладываем обратно в оригинальную очередь
        while (tempQueue.front != nullptr) {
            enqueue(tempQueue.front->data);
            tempQueue.dequeue();
        }
    }

    ~Queue() {
        clear();
    }
};

int main() {
    Stack stack;
    Queue queue;

    // Добавление элементов в стек и очередь
    for (int i = -20; i <= 60; ++i) {
        stack.push(i);
        queue.enqueue(i);
    }

    std::cout << "Initial Stack: ";
    stack.display();

    std::cout << "Initial Queue: ";
    queue.display();

    // Удаление элементов, кратных 7
    stack.removeMultiplesOf7();
    queue.removeMultiplesOf7();

    std::cout << "Stack after removing multiples of 7: ";
    stack.display();

    std::cout << "Queue after removing multiples of 7: ";
    queue.display();

    return 0;
}
