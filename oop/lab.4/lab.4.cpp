#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");

    int n;
    cout << "Введите количество элементов: ";
    cin >> n;

    if (n <= 0) {
        cout << "Некорректный размер вектора." << endl;
        return 1;
    }

    vector<double> vec(n);
    cout << "Введите элементы вектора: ";
    for (int i = 0; i < n; ++i) {
        cin >> vec[i];
    }

    // Сумма отрицательных элементов
    double sum_neg = 0.0;
    for (double num : vec) {
        if (num < 0) {
            sum_neg += num;
        }
    }

    // Поиск минимального и максимального элементов
    auto min_it = min_element(vec.begin(), vec.end());
    auto max_it = max_element(vec.begin(), vec.end());
    int min_index = min_it - vec.begin();
    int max_index = max_it - vec.begin();

    // Определение границ для произведения
    int start, end;
    if (min_index < max_index) {
        start = min_index + 1;
        end = max_index - 1;
    }
    else {
        start = max_index + 1;
        end = min_index - 1;
    }

    // Вычисление произведения
    double product = 1.0;
    if (start <= end) {
        for (int i = start; i <= end; ++i) {
            product *= vec[i];
        }
    }

    // Вывод результатов
    cout << "1) Сумма отрицательных элементов: " << sum_neg << endl;
    cout << "2) Произведение элементов между минимальным и максимальным: " << product << endl;

    return 0;
}
