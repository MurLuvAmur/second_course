#include <iostream>
#include <stack>
#include <vector>
#include <sstream>
#include <string>

using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");
    string input;
    cout << "Введите последовательность чисел через пробел: ";
    getline(cin, input); // Чтение всей строки

    vector<int> numbers;
    stringstream ss(input);
    int num;

    // Разбиваем строку на числа
    while (ss >> num) {
        numbers.push_back(num);
    }

    if (numbers.empty()) {
        cout << "Ошибка: последовательность пуста!" << endl;
        return 1;
    }

    stack<int> stack;
    size_t middle = numbers.size() / 2;

    // Помещаем первую половину в стек
    for (size_t i = 0; i < middle; ++i) {
        stack.push(numbers[i]);
    }

    // Определяем стартовый индекс для второй половины
    size_t start = (numbers.size() % 2 == 0) ? middle : middle + 1;

    bool isPalindrome = true;
    // Сравниваем вторую половину с элементами стека
    for (size_t i = start; i < numbers.size(); ++i) {
        if (stack.empty() || numbers[i] != stack.top()) {
            isPalindrome = false;
            break;
        }
        stack.pop();
    }

    if (isPalindrome) {
        cout << "Последовательность симметрична!" << endl;
    }
    else {
        cout << "Последовательность НЕ симметрична!" << endl;
    }

    return 0;
}
