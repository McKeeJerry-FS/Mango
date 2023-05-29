﻿namespace Mango.Web.Models
{
    public class ResponseDto
    {
        // This DTO is used for Common Response
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
