![GitHub last commit](https://img.shields.io/github/last-commit/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![GitHub repo size](https://img.shields.io/github/repo-size/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![GitHub language count](https://img.shields.io/github/languages/count/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![GitHub top language](https://img.shields.io/github/languages/top/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![License](https://img.shields.io/badge/license-MIT-green) [![CodeFactor](https://www.codefactor.io/repository/github/krasipeace/pchcb---asp.net-advanced-exam-project/badge)](https://www.codefactor.io/repository/github/krasipeace/pchcb---asp.net-advanced-exam-project) ![Total Lines](https://img.shields.io/tokei/lines/github/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project)

# PC's Hardware Compatibility Builder
SoftUni ASP.NET Exam Project is part of the [ASP.NET Advanced course at SoftUni](https://github.com/Krasipeace/SoftUni/tree/main/ASP.NET%20Advanced).

Table of Contents
=================

- [PC's Hardware Compatibility Builder](#pcs-hardware-compatibility-builder)
- [Table of Contents](#table-of-contents)
  - [Overview](#overview)
  - [Features](#features)
  - [Get Started](#get-started)
  - [Technologies](#technologies)

=================

## Overview

Personal Computer's Hardware Compatibility Builder is a software application that allows users to configure a custom PC configuration based on their specific needs and requirements. The app provides a user-friendly interface that guides users through the process of selecting the components they need for their PC, including the CPU, GPU, RAM, storage, case, motherboard, power supply, and cooling solutions. The app also provides users to become providers of Pc components and add them to the app's database. 

## Features

.. to be filled in

## Get Started 

Add your connection string in the `appsettings.json` file in the `PCHCB.Web` project or as secret. Apply Migrations to the `PCHCB.Data` project. Run the `PCHCB.Web` project.

You have Provider for testing purposes with the following credentials:
- Username: `admin@pchcb.com` 
- Password: `admin123`
- ID: `028F3802-11CA-4F64-90D8-7BBA2E3A74D5`
- UserID: `73DF6910-CC0D-4F98-90A0-748C29BBD618`

You can also register this Provider as Administrator by adding the following credentials to ASPNETRoles Table in the database:
- ID: `028F3802-11CA-4F64-90D8-7BBA2E3A74D5`
- Name: `Administrator`
- NormalizedName: `ADMINISTRATOR`

- As Administrator you will have full access in both client side and admin side(area) of the app.

You can also register as new User and/or Provider.

## Technologies

- ASP.NET Core 6.0
- Entity Framework Core 6.0
- MSSQL Server
- HTML / CSS / Bootstrap
- JavaScript / jQuery
