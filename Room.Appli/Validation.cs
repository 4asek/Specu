using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Specu.Application.Entities;

namespace Specu.Application
{
    public class RoomValidator : AbstractValidator<Room>
    {
        RuleFor(room => room.Surname).NotNull();


        Room room = new Room();
        RoomValidator validator = new RoomValidator();
        ValidationResult result = validator.Validate(room);

    }
}
