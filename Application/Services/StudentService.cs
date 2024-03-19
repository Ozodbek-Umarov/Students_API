using Application.Common;
using Application.DTOs.StudentDtos;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;
using Infrastructures.Interfaces;

namespace Application.Services;

public class StudentService : IStudentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IValidator<Student> _validator;

    public StudentService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Student> validator)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _validator = validator;
    }
    public async Task AddAsync(AddStudentDto dto)
    {
        if (dto  == null)
            throw new StudentExeption("Student bo'sh bo'lmasin");
        var student = _mapper.Map<Student>(dto);
        var result = await _validator.ValidateAsync(student);
        if (!result.IsValid)
        {
            throw new StudentExeption(result.ToString());
        }
        await _unitOfWork.studentInterface.AddAsync(student);
    }

    public async Task DeleteAsync(int id)
    {
        var model = await _unitOfWork.studentInterface.GetByIdAsync(id);
        if (model == null)
            throw new NotFoundExeption("Student Topilmadi");
        await _unitOfWork.studentInterface.DeleteAsync(model);
    }

    public async Task<List<StudentDto>> GetAllAsync()
    {
        var list = await _unitOfWork.studentInterface.GetAllAsync();
        return list.Select(_mapper.Map<StudentDto>).ToList();
    }

    public async Task<StudentDto> GetByIdAsync(int id)
    {
        var model = await _unitOfWork.studentInterface.GetByIdAsync(id);
        if (model == null)
            throw new NotFoundExeption("student topilmadi");
        return _mapper.Map<StudentDto>(model);
    }

    public async Task UpdateAsync(StudentDto dto)
    {
        var model = await _unitOfWork.studentInterface.GetByIdAsync(dto.Id);
        if (model == null)
            throw new NotFoundExeption("student topilmadi");
        var student = _mapper.Map<Student>(dto);
        var result = await _validator.ValidateAsync(student);
        if (!result.IsValid)
            throw new StudentExeption("qandaydur xato");

        await _unitOfWork.studentInterface.UpdateAsync(student);
    }
}
