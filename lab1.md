# Лабораторная работа 1
![diagram](/assets/lab1.png)


#### 1. Прецедент "Вход в игру"
| Описание  |  Игроки вводят свои имена и получают фишки |
| ------------ | ------------ |
|  Основной исполнитель | Игрок  |
| Предусловия  | Игра ещё не начата  |
|  Постусловия |  Игроки зарегистрированы, фишки выданы, определен первый ход |
##### Основной сценарий прецедента
| Действия игрока  | Отклик системы  |
| ------------ | ------------ |
|   |  1. Запросить имя игрока |
| 2. Ввести имя  |   |
|   |  3. Выдать игроку 7 случайных фишек |
|   |  4. Запросить имя следующего игрока |
| 5. Ввести имя, указать, что это последний игрок  |   |
|   |  6. Завершить регистрацию игроков. |
|   |  7. Определить очередность. |
##### Альтернативный сценарий
5а. Если игрок не последний, повторить пункты 1 - 5. 
7а. Игра начинается с игрока, у которого есть кость дубль 1-1 или с наименьшего дубля. Остальные ходя по кругу.

#### 2. Прецедент "Сделать ход"
| Описание  |  Игроки вводят свои имена и получают фишки |
| ------------ | ------------ |
|  Основной исполнитель | Игрок  |
| Предусловия  | Подошла очередь игрока, нет игроков с 125 очками  |
|  Постусловия |  У игрока закончились кости или ни у кого нет возможности хода |

##### Основной сценарий прецедента
| Действия игрока  | Отклик системы  |
| ------------ | ------------ |
| 1. Выложить кость на стол  |   |
|   | 2. Проверить соответствие сторон с одинаковым количеством очков  |
|   | 3. Передать ход следующему игроку  |
##### Альтернативный сценарий
###### 1а. Если у игрока нет подходящей кости
1. Он берет из свободных
2. Если свободные кости закончились, ход переходит следующему игроку

###### 1б. Ни у кого нет подходящей кости
1. Ситуация "рыба"- конец раунда, подсчет очков
1.1 Если у всех игроков одинаковое количество очков, то очки - "яйца" приписываются следующему проигравшему

#### 3. Прецедент "Завершить раунд"

| Описание  |  Игроки вводят свои имена и получают фишки |
| ------------ | ------------ |
|  Основной исполнитель | Игрок  |
| Предусловия  | У игрока закончились кости  |
|  Постусловия |  Очки у игроков подсчитаны |
##### Основной сценарий прецедента
| Действия игрока  | Отклик системы  |
| ------------ | ------------ |
| 1. Выложить последнюю кость на стол  |   |
|   | 2. Проверить соответствие сторон с одинаковым количеством очков  |
|   | 3. Подсчитать проигрышные очки у всех игроков  |


#### 4. Прецедент "Завершить игру"
| Описание  |  Игроки вводят свои имена и получают фишки |
| ------------ | ------------ |
|  Основной исполнитель | Игрок  |
| Предусловия  | Игрок набрал 125 очков  |
|  Постусловия |  Выявлен проигравший игрок |

##### Основной сценарий прецедента
| Действия игрока  | Отклик системы  |
| ------------ | ------------ |
|  1. Узнать результаты |   |
|   | 2. Подсчитать сумму очков всех игроков  |
|   | 3. Назначить игрока с 125 и больше очков проигравшим  |
