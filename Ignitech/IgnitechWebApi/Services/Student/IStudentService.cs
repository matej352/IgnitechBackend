﻿using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Services.Student
{
    public interface IStudentService
    {
        public Task<UserDto> CreateStudent(CreateStudentDto student);
        public Task<IEnumerable<CreateUserDto>> GetStudents(Guid teacherCode);
    }
}
