using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Datas;

namespace UnicomTICManagementSystem.Repositories
{
    public static class Migration
    {
        public static void CreateTables()
        {
            using (var conn = DBConfig.GetConnection())
            {
                string tableCreation = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Email TEXT NOT NULL UNIQUE,
                        Role TEXT NOT NULL,
                        CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );

                     CREATE TABLE IF NOT EXISTS PendingUsers (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Email TEXT NOT NULL UNIQUE,
                        Role TEXT NOT NULL,
                        CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );

                    CREATE TABLE IF NOT EXISTS Staffs (
                        StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Email TEXT NOT NULL UNIQUE,
                        UserID INTEGER,
                        FOREIGN KEY (UserID) REFERENCES Users(UserID)
                    );

                     CREATE TABLE IF NOT EXISTS Lecturers  (
                        LectureID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Email TEXT NOT NULL UNIQUE,
                        UserID INTEGER,
                        FOREIGN KEY (UserID) REFERENCES Users(UserID)
                    );

                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Modules (
                        ModuleID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ModuleName TEXT NOT NULL,
                        CourseID INTEGER
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );

                     CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        DOB TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        CourseID INTEGER,
                        UserID INTEGER,
                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
                        FOREIGN KEY (UserID) REFERENCES Users(UserID)
                    );
    
                     CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        ModuleID INTEGER,
                        RoomID INTEGER,
                        Date TEXT,
                        StartTime TEXT NOT NULL,
                        EndTime TEXT NOT NULL,
                        FOREIGN KEY (ModuleID) REFERENCES Modules(ModuleID),
                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)

                    );

                    CREATE TABLE IF NOT EXISTS Marks (
                        MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER NOT NULL,
                        ExamID INTEGER NOT NULL,
                        Score INTEGER NOT NULL,
                        Results TEXT NOT NULL,
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
                    );
    
                    CREATE TABLE IF NOT EXISTS TimeTables (
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ModuleID INTEGER NOT NULL,
                        Date TEXT NOT NULL,
                        StartTime TIME NOT NULL,
                        EndTime TIME NOT NULL,
                        RoomID INTEGER NOT NULL,
                        FOREIGN KEY (ModuleID) REFERENCES Modules(ModuleID),
                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                    );

         
                    CREATE TABLE IF NOT EXISTS Attendances_new (
                        AttendanceID INTEGER PRIMARY KEY AUTOINCREMENT,
                        TimetableID INTEGER NOT NULL,
                        StudentID INTEGER NOT NULL,
                        Status TEXT NOT NULL,
                        LogIn DATETIME NULL,
                        LogOut DATETIME NULL,
                        FOREIGN KEY (TimetableID) REFERENCES TimeTables(TimetableID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID)

                    );

                    CREATE TABLE IF NOT EXISTS StudentLecturer (
                        StudentID INTEGER NOT NULL,
                        LectureID INTEGER NOT NULL,
                        PRIMARY KEY (StudentID, LectureID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (LectureID) REFERENCES Lecturers (LectureID)
                    );

                    CREATE TABLE IF NOT EXISTS LectureModule (
                        LectureID INTEGER NOT NULL,
                        ModuleID INTEGER NOT NULL,
                        PRIMARY KEY (LectureID, ModuleID),
                        FOREIGN KEY (LectureID) REFERENCES Lecturers (LectureID),
                        FOREIGN KEY (ModuleID) REFERENCES Modules(ModuleID)
                    );
                ";

                SQLiteCommand command = new SQLiteCommand(tableCreation, conn);
                command.ExecuteNonQuery();

            }
        }
    }
}
    
