-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Апр 21 2025 г., 17:28
-- Версия сервера: 5.7.24
-- Версия PHP: 7.1.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `cafebase`
--

-- --------------------------------------------------------

--
-- Структура таблицы `access_rights`
--

CREATE TABLE `access_rights` (
  `id` int(11) NOT NULL,
  `Name` text NOT NULL,
  `Surname` text NOT NULL,
  `Job_title` enum('Администратор','Официант','Повар') NOT NULL,
  `Status` enum('Уволен','Активен') NOT NULL,
  `Login` text NOT NULL,
  `Password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `access_rights`
--

INSERT INTO `access_rights` (`id`, `Name`, `Surname`, `Job_title`, `Status`, `Login`, `Password`) VALUES
(1, 'Герман', 'Столяров', 'Администратор', 'Активен', '1', '1'),
(2, 'Артём', 'Папикян', 'Повар', 'Активен', '2', '2'),
(3, 'Данила', 'Табулин', 'Официант', 'Активен', '3', '3'),
(4, 'Павел', 'Буршин', 'Повар', 'Активен', '4', '4'),
(6, 'Гусений', 'Горлованов', 'Повар', 'Активен', '213', '213'),
(7, 'Кирилл', 'Вишняков', 'Официант', 'Активен', '1233', '123');

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL,
  `ReadyOrNot` enum('Готово','Не готово') NOT NULL,
  `TableNumber` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `OrderDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `DishNames` varchar(255) NOT NULL,
  `WaiterID` int(11) DEFAULT NULL,
  `CookID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `orders`
--

INSERT INTO `orders` (`OrderID`, `ReadyOrNot`, `TableNumber`, `Quantity`, `OrderDate`, `DishNames`, `WaiterID`, `CookID`) VALUES
(1, 'Готово', 5, 2, '2025-03-04 12:00:00', 'Паста с соусом песто и курицей', 2, 6),
(2, 'Не готово', 2, 1, '2025-03-04 12:15:00', 'Лосось в медово-горчичном соусе', 2, 6),
(3, 'Не готово', 3, 3, '2025-03-04 12:30:00', 'Говядина по-азиатски с рисом', 2, 4),
(4, 'Не готово', 1, 4, '2025-03-04 13:00:00', 'Фисташковый стейк с грибным соусом', 2, 6),
(5, 'Не готово', 4, 2, '2025-03-04 13:15:00', 'Суп \"Римская охота\"', 2, 6),
(6, 'Не готово', 1, 10, '2025-03-05 08:26:30', 'Огурец , помидор , вода , мясо , барана , чай , трапеция мидий', 6, 4),
(7, 'Не готово', 8, 1, '2025-05-01 10:10:01', 'Вода , Каша', 2, 6),
(8, 'Не готово', 5, 7, '2025-03-05 10:33:31', 'Вода , Сок , Мясо , Рыба', 7, 2),
(9, 'Не готово', 1, 1, '2025-03-05 12:11:49', 'Макароны под водой', 7, 4);

-- --------------------------------------------------------

--
-- Структура таблицы `shifts`
--

CREATE TABLE `shifts` (
  `id` int(11) NOT NULL,
  `Userid` int(11) NOT NULL,
  `ShiftsDate` date NOT NULL,
  `Shiftstime` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `shifts`
--

INSERT INTO `shifts` (`id`, `Userid`, `ShiftsDate`, `Shiftstime`) VALUES
(1, 1, '2025-03-07', '08:00:00'),
(2, 2, '2025-03-07', '08:00:00'),
(3, 3, '2025-03-07', '08:00:00'),
(4, 4, '2025-03-07', '08:00:00'),
(5, 6, '2025-03-07', '08:00:00'),
(6, 7, '2025-03-07', '08:00:00');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `access_rights`
--
ALTER TABLE `access_rights`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `CookID` (`CookID`),
  ADD KEY `WaiterID` (`WaiterID`);

--
-- Индексы таблицы `shifts`
--
ALTER TABLE `shifts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Userid` (`Userid`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `access_rights`
--
ALTER TABLE `access_rights`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `shifts`
--
ALTER TABLE `shifts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`CookID`) REFERENCES `access_rights` (`id`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`WaiterID`) REFERENCES `access_rights` (`id`);

--
-- Ограничения внешнего ключа таблицы `shifts`
--
ALTER TABLE `shifts`
  ADD CONSTRAINT `shifts_ibfk_1` FOREIGN KEY (`Userid`) REFERENCES `access_rights` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
