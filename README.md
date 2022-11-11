# Cinema System

## Overview

This is a cinema system that allows users to register and make reservations for a made up cinema.

## Features
The first window that is presented to the user when the program opens is the login window where users can login to access their reservations. If the user does not have an account they can create one by clicking the button at the bottom of the window. In the registration window the new user has to fill in the required data and will be returned to the login window. The date of birth is required so that underage users are prevented form reserving films that are intended for mature audiences.

When the user logins they are presented with a window which lists all their reservations (if they have any), where they can create new reservations or cancel existing ones.To remove a reservation highlight it by clicking on it and click the remove reservation button.

Adding a reservation opens a new window where the user can choose the time period, hall and movie they are interested in. By clicking on the show projections button the program will list all projections that match the parameters. By changing the number of seats the price will automatically adjust. The user can canel the reservation or reset the filters at any time.

There is also an admin account which has access to all user information and has the ability to add remove or update reservations.  
username: admin  
pass: admin

Information about users, movies, projections and reservations are stored in seperate files.

## Screenshots

Here are a few screenshots:

- Login:![login]
- Reservation:![reservation]
- Admin:![admin]

[login]: ./screenshots/Login.png
[reservation]: ./screenshots/Reservation.png
[admin]: ./screenshots/Admin.png
