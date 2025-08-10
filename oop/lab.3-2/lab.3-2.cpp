#include <iostream>
#include <fstream>
#include <vector>
#include <string>

using namespace std;

int main() {
    setlocale(LC_ALL, "ru_RU.UTF-8");
    ifstream file("file.txt");
    vector<string> sentences;
    string line;

    if (!file.is_open()) {
        cerr << "error" << endl;
        return 1;
    }

    while (getline(file, line)) {
        sentences.push_back(line);
        if (sentences.size() >= 3) break; // Читаем не более трёх строк
    }

    file.close();

    cout << "Результат:\n";
    // Выводим строки в обратном порядке, но только существующие
    for (int i = sentences.size() - 1; i >= 0; --i) {
        cout << sentences[i] << endl;
    }

    return 0;
}
