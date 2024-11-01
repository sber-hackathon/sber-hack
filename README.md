# sber-hackhaton

## КОПИРОВАНИЕ РЕПОЗИТОРИЯ
* ПКМ ПО РАБОЧЕМУ СТОЛУ ИЛИ ДР. ПАПКЕ
* Open Git Bash here, фото снизу<br>
![image](https://github.com/user-attachments/assets/c8d48200-2154-44bc-9166-0e38308496d3)
* Пишем туда `git clone <url>`

В нашем случае:
```git
git clone https://github.com/sber-hackathon/sber-hack.git
```
![image](https://github.com/user-attachments/assets/2ce5b037-78ce-4de6-8b3f-c04b984ec063)

## СОЗДАЕМ СВОЮ ВЕТКУ
* ПЕРЕХОДИМ В ПАПКУ, КОТОРАЯ СОЗДАЛАСЬ ПОСЛЕ ПРЕДИДУЩЕЙ КОМАНДЫ
* ПОВТОРЯЕМ ПКМ -> Open Git Bash here <br>
![image](https://github.com/user-attachments/assets/1a121c86-07bd-4128-a86a-4deec1805800)
* ПИШЕМ `git checkout -b "НАЗВАНИЕ ВЕТКИ"` <br>
![image](https://github.com/user-attachments/assets/6a618236-2647-4b10-800f-98b439fcb7e9)

## ВНЕСЕНИЕ ИЗМЕНЕНИЙ
* !!! В СВОЕЙ ВЕТКЕ !!!
1. Проверяем `git status`
2. Пишем `git commit -m "ЧТО ДОБАВИЛИ/ИЗМЕНИЛИ"` (в скобках описание что поменялось)
   * МОЖЕТ НЕ СРАБОТАТЬ, НЕОБХОДИМО ВЫЙТИ ИЗ VS 
4. Опять проверяем `git status`, если все зеленое, то кайф
5. git push origin <название вашей ветки>
   * НАПРИМЕР `git push origin vasya`
