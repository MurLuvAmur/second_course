#include <iostream>
#include <fstream>
using namespace std;

int main() {
    string filename;
    int N;

    // Ввод имени файла и числа N
    cout << "Введите имя файла: ";
    cin >> filename;
    cout << "Введите N (>1): ";
    cin >> N;

    // Проверка корректности N
    if (N <= 1) {
        cerr << "Ошибка: N должно быть больше 1!" << endl;
        return 1;
    }

    // Создание и открытие файла
    ofstream file(filename);
    if (!file.is_open()) {
        cerr << "Ошибка создания файла!" << endl;
        return 1;
    }

    // Запись чисел в файл
    for (int i = 1; i <= N; ++i) {
        int num = 2 * i;
        file << num;
        if (i != N) file << " "; // Добавляем пробел между числами
    }

    file.close();
    cout << "Файл успешно создан!" << endl;
    return 0;
}
