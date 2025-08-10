#include <iostream>
#include <stack>
#include <string>

using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");
    string input;
    cout << "Введите строку: ";
    getline(cin, input); // Чтение строки с учётом пробелов

    stack<char> charStack; // Стек для хранения символов

    // Помещаем каждый символ строки в стек
    for (char c : input) {
        charStack.push(c);
    }

    // Извлекаем символы из стека для формирования перевёрнутой строки
    string reversedString;
    while (!charStack.empty()) {
        reversedString += charStack.top(); // Добавляем верхний элемент
        charStack.pop(); // Удаляем верхний элемент
    }

    cout << "Перевёрнутая строка: " << reversedString << endl;

    return 0;
}
