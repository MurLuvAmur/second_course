#include <iostream>
#include <string>

using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");
    string input;
    string vowels = "aeiouyAEIOUY";
    string result;

    // Ввод строки
    cout << "Введите строку: ";
    getline(cin, input);

    // Фильтрация гласных
    for (char c : input) {
        if (vowels.find(c) == string::npos) {
            result += c;
        }
    }

    // Вывод результата
    cout << "Результат: " << result << endl;

    return 0;
}
