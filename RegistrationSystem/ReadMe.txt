							ReadMe File for RegistrationSystem DB(Register/Login Form)

-Implemented a Registration, Login and Logout System with PHP and MySQL.

-Created a database (database name: RegistrationSystem) using phpMyAdmin and 
  table named users.
  
-User adding form so that logged in user can insert a new user.

-That form had first name, last name, password and email adding system.

-Added a user menu which will show the inserted/registered users in a table (create new table: new_users).

-In the table beside each user there is an action column. In the action column, we
 had a delete button so that if we click on delete button then that user becomes deleted.

Sql query for table users: 

CREATE TABLE IF NOT EXISTS `users` (
 `id` int(11) NOT NULL AUTO_INCREMENT,
 `username` varchar(50) NOT NULL,
 `email` varchar(50) NOT NULL,
 `password` varchar(50) NOT NULL,
 `create_datetime` datetime NOT NULL,
 PRIMARY KEY (`id`)
);


Sql query for table new_users:

CREATE TABLE IF NOT EXISTS `new_users` (
 `id` int(11) NOT NULL AUTO_INCREMENT,
 `create_datetime` datetime NOT NULL,
 `name` varchar(100) NOT NULL,
 `lastname` varchar(100) NOT NULL,
 `password` varchar(100) NOT NULL,
 `email` varchar(100) NOT NULL,
 `submittedby` varchar(50) NOT NULL,
 PRIMARY KEY (`id`)
 );
 
Sources:

	https://speedysense.com/create-registration-login-system-php-mysql

	https://www.allphptricks.com/insert-view-edit-and-delete-record-from-database-using-php-and-mysqli/