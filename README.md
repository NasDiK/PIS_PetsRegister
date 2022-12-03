# 16. Реестр объявлений о пропаже домашнего животного
---

## Баги и нереализованные фичи
---
>### Баги
>> - Регистрация гостя - кнопка "зарегистрироваться" не влазит в бокс
>> - При регистрации гостя имя пользователя обязательно. Ожид. рез-т: либо номер телефона, либо имя пользователя, но как минимум что-то
>> - Регистрация гостя - бокс неограниченного размера. Ожид. рез-т: фикс размер
>> - При дабл клике на DGV должен открывать объявление текущей строки
>> - ~~Мои ДЖ доступны только вновь зарегистрированным пользователям. Ожид. рез-т: пользователи с группой "owner"~~ (Maked/30.11.2022)
>> - Маска скрытия пароля костыльная. Сейчас: new TextBox().passwordChar. Ожид. рез-т: отдебажить и посмотреть какой символ в оригинале - его поставить
>> - ~~При открытии объявления открывает одно и то же объявление. Ожид. рез-т: открывает конкретное объявление из кеша~~ (Maked/02.12.2022)
>> - ~~При изменении объявления открывает одно и то же объявление. Ожид. рез-т: открывает конкретное объявление из кеша~~ (Maked/02.12.2022)
>> - Корявая регулярка в фильтре пунктов населений. Баг описан в коде. //Фильтр форма
>> - Корявая регулярка в фильтре дат. Реализовано только \> и \<. Надо ещё = \>= \<= 
>> - ~~Кнопка "отображать только мои" не связана с dataTable - оставить Саше~~ (Maked/30.11.2022)
>> - ~~Нет иконки на карточке объявления. Ожид. рез-т: иконка как на каждой форме~~(Maked/03.12.2022)
>> - В карточке животного не все поля объявления //Карточка животного - объявление. Сделает саша
>> - В таблице всех объявлений не все колонки полей объявления
>> - ~~При загрузке фотографии оно не отображается в PictureBox~~ (Maked/02.12.2022)
>> - ~~При подаче объявлений фото не загружается (реализовано только при изменении)~~ (Maked/02.12.2022)
>> - Текст кнопка загрузки фотографии немного смещен внутри.


>### Нереализованные фичи
>> - Ререндер кнопок при клике на строчку (проверка прав) //Все объявления
>> - Нет фотографии в реестре объявлений //Все объявления - должна быть основная || Любая
>> - Вид отображения (значки/таблица) ??? //Все объявления
>> - ~~Фильтр записывается в переменную allAdsForm, но никак не используется //Все объявления~~ (Maked/01.12.2022)
>> - Красить кнопки во всём проекте(редизайн) //Весь проект
>> - Блок "Мои ДЖ"//Мои ДЖ - вообще блока нет. Реализация фото не нужна, поск. Photographies крепится к объявлению, а не к владельцу животного
>> - При подаче объявления подставляется одно из твоих ДЖ //Подача объявлений
>> - ~~Загрузка и хранение фотографий + настройка openFileDialog~~(Maked/02.12.2022)
>> - Удаление фотографий + кнопка "сделать основной" - в карточке животного для permitted на это людей. (т.е. + проверка прав)
>> - ~~Переключение фотографий~~(Maked/02.12.2022)
>> - Экспорт word/excel с выбором места сохранения ЛЕША
>> - Удаление объявлений 
>> - ~~Сохранение изменение объявлений~~ (Maked/02.12.2022)
>> - Дабл клик по DataTable открывает карточку //Все объявления


По желанию:
- Написать Unit тесты, заготовочки имеются)
- Написать dockerfile, сделать образ постгресс и накатить миграции + дописать сиды. Приложить сюда ссылку на DockerHub-е.
- Обновление сущностей упразднить через Utils метод -> Рефлексия. Нужен метод который поля одного объекта переписывает по полям второго

---

# Состав команды:
    Тунгусов Александр
    Кувшанов Роман
    Борботко Алексей

---
# Описание

## Роли в системе

| Роль | Права  | DB_name
| --------- | -----  | ---
| Администратор | Просмотр, удаление, изменение в рамках всех записей реестра | admin
| Пользователь | Просмотр всех, удаление/изменение своих записей в реестре | owner

## Функции

| Функция | Компонент | Роль | Примечание |
| --------- | -----  | --- | ---- |
| Открыть | Ведения реестров | Любая, которой доступен реестр | Функция инициирует открытие окна учётной карточки выделенной записи для просмотра | 
| Задать в поле таблицы фильтр | Ведения реестров | Любая, которой доступен реестр | Функция доступна в каждом поле реестра заявок на отлов животных без владельцев | 
| Задать в поле таблицы условия сортировки | Ведения реестров | Любая, которой доступен реестр |  | 
| Удалить | Ведения реестров журналирования, контроля | Администратор данных |  | 


## Блок "Мои ДЖ"

В блоке будет представлен список домашних животных из реестра учёта домашних животных **(далее – окно реестра учёта ДЖ)** в одном из видов представления, устанавливаемых пользователем:

1. в виде таблицы в составе следующих столбцов (полей):
- Категория животного;
- Имя животного;
- Дата рождения;
- Порода;
- Дата регистрации животного;
- Номер паспорта домашнего животного;
- ФИО владельца домашнего животного.

  Количество строк (записей) в таблице определяется количеством домашних животных, владельцем которых является данный пользователь Системы.

2. в виде значков, в качестве которых будет использована фотография животного, 
с надписью (имя животного) под значком.

***Функции***

| **Функция** | **Компонент** | **Примечание** |
| --- | ---| --- |
| *в окне реестра учёта ДЖ* |
| Задать вид представления | ведения реестров | Пользователь может задать вид представления (табличный, значки). По умолчанию будет установлен вид представления «значки» |
| Открыть | ведения реестров | Функция инициирует открытие окна учётной карточки домашнего животного выделенной записи/значка |
| Задать в поле таблицы фильтр | ведения реестров <td rowspan=2>Функция доступна в каждом поле таблицы</td>
| Задать в поле таблицы условия сортировки  | ведения реестров | |
| Экспорт записей в MS Excel | выгрузки данных | Пользователь может выгрузить таблицу в файл Excel. Выгружаются записи, удовлетворяющие условиям установленных фильтров |
| *в окне учётной карточки домашнего животного* <br> **Примечание:** окно состоит из закладок: Основные характеристики животного; Вакцинация; Дегельминтизация/ Обработка от экто- и эндопаразитов; Ветеринарные назначения; Фото/документы |
| Сформировать паспорт ДЖ в Word | выгрузки данных | Пользователь может выгрузить паспорт домашнего животного в файл Word, (ПРИЛОЖЕНИЕ 1) |
| Задать в поле таблицы фильтр | ведения реестров <td rowspan=2>Функция доступна в каждом поле таблицы</td>
| Задать в поле таблицы условия сортировки  | ведения реестров | |
| Экспорт записей в MS Excel | выгрузки данных | Пользователь может выгрузить таблицу в файл Excel. Выгружаются записи, удовлетворяющие условиям установленных фильтров |

## Блок "Мои объявления"

В окне «Мои объявления» будет представлен список объявлений из реестра объявлений о пропаже домашнего животного **(далее – окно реестра о пропаже)** в виде списка учётных карточек животных со следующим набором характеристик:

- Дата размещения объявления;
- Фотография животного;
- Кличка животного;
- Пол животного;
- Населённый пункт.

Количество строк (записей) в таблице определяется количеством объявлений, поданных и не удаленных пользователем Системы.
По умолчанию Система открывает закладку со списком объявлений о пропаже.
В окне предусмотрен фильтр для ограничения отображаемой выборки. Фильтрация осуществляется по следующим полям карточки объявления о пропаже домашнего животного:
- Населённый пункт пропажи животного;
- Категория животного;
- Дата пропажи животного.

В перечне отобразятся учётные карточки, удовлетворяющие заданным критериям поиска.

***Функции***

| **Функция** | **Компонент** | **Примечание** |
| --- | ---| --- |
| в окне реестра о пропаже |
| Открыть | ведения реестров | Функция инициирует открытие окна учётной карточки о пропаже |
| Подать объявление | ведения реестров, контроля | Функция инициирует открытие окна пустой учётной карточки о пропаже в режиме редактирования |
| Удалить  | ведения реестров, контроля | Система удаляет выделенные записи с предварительным запросом подтверждения действия |
| Задать фильтр | ведения реестров | Функция позволяет задать фильтр по населённому пункту, категории животного или дате пропажи. |
| в окне учётной карточки о пропаже* |
| Удалить | ведения реестров; контроля | Пользователь может удалить учётную карточку с предварительным подтверждением действия  |
| Редактировать | ведения реестров; контроля | Система переводит открытую учётную карточку в режим редактирования с возможностью загрузить фотографии |

**Примечание:** при подаче объявления о пропаже домашнего животного, зарегистрированного в Системе, владелец (пользователь Системы) должен иметь возможность заполнить учётную карточку о пропаже на основе учётной карточки домашнего животного.

## Доска объявлений о пропавших животных

Данный раздел доступен пользователям с ролями: «Гость» или «Владелец». 
В двух закладках раздела будет представлен список объявлений из реестра объявлений о находке животного и список объявлений из реестра объявлений о пропаже домашнего животного в виде списка учётных карточек животных со следующим набором характеристик:

- Дата размещения объявления;
- Фотография животного;
- Кличка животного;
- Пол животного;
- Населённый пункт.

Количество записей определяется количеством объявлений о пропаже домашних животных.
В окне предусмотрен фильтр для ограничения отображаемой выборки. Фильтрация осуществляется по следующим полям карточки объявления о пропаже домашнего животного:

- Населённый пункт пропажи животного;
- Категория животного;
- Дата пропажи животного.

В перечне отобразятся учётные карточки, удовлетворяющие заданным критериям поиска.

***Функции***

| **Функция** | **Компонент** | **Примечание** |
| --- | ---| --- |
| в окне реестра о пропаже |
| Открыть | ведения реестров | Функция инициирует открытие окна учётной карточки о пропаже |
| Подать объявление | ведения реестров, контроля | Функция инициирует открытие окна пустой учётной карточки о пропаже в режиме редактирования. <br> Для неавторизованного пользователя Система предложит войти или зарегистрироваться. <br> Для пользователя роли «Гость» регистрация будет выполнена по номеру мобильного телефона |
| Работа с объявлениями пользователя**  | ведения реестров, контроля | Функция инициирует открытие окна «Мои объявления» в Личном кабинете пользователя. <br> В случае, если пользователь не авторизован, Система должна предложить войти либо зарегистрироваться |
| Задать фильтр | ведения реестров | Функция позволяет задать фильтр по населённому пункту, категории животного или дате пропажи. |
| в окне учётной карточки о пропаже* |
| Прикрепить фотографии | ведения реестров | Функция инициирует открытие окна для сохранения фотографий |
| Отметить основную фотографию | ведения реестров | Пользователь может отметить одну фотографию как основную |

****Примечание:** при подаче объявления о пропаже домашнего животного, зарегистрированного в Системе, авторизованный пользователь Системы, при наличии у него роли «Владелец», должен иметь возможность заполнить учётную карточку о пропаже на основе учётной карточки домашнего животного.
