#include <iostream>
#include <list>
#include <string>
#include <algorithm>
#include <locale.h>
#include <windows.h>


using namespace std;

// Перечисление для статуса автобуса
enum BusStatus {
    IN_DEPOT,
    ON_ROUTE
};

// Структура для хранения информации об автобусе
struct Bus {
    int number;             
    string driverName;      
    int routeNumber;        
    BusStatus status;       

    // Конструктор для удобного создания объектов
    Bus(int num, const string& name, int route, BusStatus st)
        : number(num), driverName(name), routeNumber(route), status(st) {}
};

// Функция для вывода информации об автобусе
void printBus(const Bus& bus) {
    cout << "Номер автобуса: " << bus.number << endl;
    cout << "Водитель: " << bus.driverName << endl;
    cout << "Номер маршрута: " << bus.routeNumber << endl;
    cout << "Статус: " << (bus.status == IN_DEPOT ? "В парке" : "На маршруте") << endl;
    cout << "-----------------------------" << endl;
}

int main() {
    setlocale(LC_ALL, "Russian");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);


    list<Bus> busDepot;
    int choice;

    // Начальное формирование данных
    cout << "Введите начальные данные об автобусах (для завершения введите 0):" << endl;
    while (true) {
        int number, route;
        string name;
        char status;

        cout << "Номер автобуса (0 для завершения): ";
        cin >> number;
        if (number == 0) break;

        cout << "Фамилия и инициалы водителя: ";
        cin.ignore();
        getline(cin, name);

        cout << "Номер маршрута: ";
        cin >> route;

        cout << "Статус (D - в парке, R - на маршруте): ";
        cin >> status;

        BusStatus busStatus = (toupper(status) == 'D') ? IN_DEPOT : ON_ROUTE;
        busDepot.emplace_back(number, name, route, busStatus);
    }

    while (true) {
        cout << "\nМеню:\n";
        cout << "1. Выезд автобуса из парка\n";
        cout << "2. Въезд автобуса в парк\n";
        cout << "3. Сведения об автобусах в парке\n";
        cout << "4. Сведения об автобусах на маршруте\n";
        cout << "5. Выход\n";
        cout << "Выберите действие: ";
        cin >> choice;

        if (choice == 5) break;

        switch (choice) {
        case 1: {
            // Выезд автобуса из парка
            int busNumber;
            cout << "Введите номер автобуса: ";
            cin >> busNumber;

            auto it = find_if(busDepot.begin(), busDepot.end(),
                [busNumber](const Bus& b) { return b.number == busNumber; });

            if (it != busDepot.end()) {
                if (it->status == IN_DEPOT) {
                    it->status = ON_ROUTE;
                    cout << "Автобус " << busNumber << " теперь на маршруте.\n";
                }
                else {
                    cout << "Автобус уже на маршруте.\n";
                }
            }
            else {
                cout << "Автобус с таким номером не найден.\n";
            }
            break;
        }
        case 2: {
            // Въезд автобуса в парк
            int busNumber;
            cout << "Введите номер автобуса: ";
            cin >> busNumber;

            auto it = find_if(busDepot.begin(), busDepot.end(),
                [busNumber](const Bus& b) { return b.number == busNumber; });

            if (it != busDepot.end()) {
                if (it->status == ON_ROUTE) {
                    it->status = IN_DEPOT;
                    cout << "Автобус " << busNumber << " теперь в парке.\n";
                }
                else {
                    cout << "Автобус уже в парке.\n";
                }
            }
            else {
                cout << "Автобус с таким номером не найден.\n";
            }
            break;
        }
        case 3: {
            // Сведения об автобусах в парке
            cout << "\nАвтобусы в парке:\n";
            for (const auto& bus : busDepot) {
                if (bus.status == IN_DEPOT) {
                    printBus(bus);
                }
            }
            break;
        }
        case 4: {
            // Сведения об автобусах на маршруте
            cout << "\nАвтобусы на маршруте:\n";
            for (const auto& bus : busDepot) {
                if (bus.status == ON_ROUTE) {
                    printBus(bus);
                }
            }
            break;
        }
        default:
            cout << "Неверный выбор. Попробуйте снова.\n";
        }
    }

    return 0;
}