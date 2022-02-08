using System;

namespace ImplicitАndExplicitOperatorsOverClassessOrStructs.ExampleOne
{
    public  class MessageTableEntity
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public string CreatedBy { get; set; }

        /// <summary>
        /// So the DTO class doesn’t need to see who creates the message, 
        /// let’s say that it’s private information and we don’t want to make it visible. 
        /// For any conversion between the table entity and the DTO, we will make something like the following:
        /// However, if we need to do this several times for classes with multiple properties, it will be 
        /// boring work. There is no need to have several methods to make the mapping between classes.
        /// </summary>
        /// <param name="tableEntity"></param>
        /// <returns></returns>
        public MessageDto ConvertToDto(MessageTableEntity tableEntity)
        {
            MessageDto dto = new MessageDto
            {
                Id = tableEntity.Id.ToString(),
                Message = tableEntity.Message
            };
            return dto;
        }

        //duplicate user-defined conversion error when two operators are defined
        //public static implicit operator MessageDto(MessageTableEntity entity)
        //{
        //    return new MessageDto
        //    {
        //        Id = entity.Id.ToString(),
        //        Message = entity.Message
        //    };
        //}

        //duplicate user-defined conversion error when two operators are defined
        public static explicit operator MessageDto(
                                      MessageTableEntity entity)
        {
            return new MessageDto
            {
                Id = entity.Id.ToString(),
                Message = entity.Message
            };
        }
    }
}
