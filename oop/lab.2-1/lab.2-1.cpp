#include <fstream>
#include <iostream>
using namespace std;

int main() {
    // Открываем файл для чтения
    ifstream in("file.txt");
    if (!in) {
        cerr << "Не удалось открыть файл для чтения." << endl;
        return 1;
    }

    double num, sum = 0.0;

    // Считываем числа и суммируем их
    while (in >> num) {
        sum += num;
    }

    in.close();

    // Открываем файл для добавления суммы в конец
    ofstream out("file.txt", ios::app);
    if (!out) {
        cerr << "Не удалось открыть файл для записи." << endl;
        return 1;
    }

    // Записываем сумму на новой строке
    out << endl << sum;
    out.close();

    return 0;
}
