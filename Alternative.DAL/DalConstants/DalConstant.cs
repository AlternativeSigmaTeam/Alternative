using System;
using System.Collections.Generic;
using System.Text;

namespace Alternative.DAL.DalConstants
{
    public class DalConstants
    {
        //Alternatives

        public static Guid KmosId { get; set; } = Guid.Parse("5466785b-5c3a-43c5-0339-08d726f8ab68");
        public static Guid AofmId { get; set; } = Guid.Parse("f52a318f-877a-4472-a0b9-07bc25810563");
        public static Guid RtsId { get; set; } = Guid.Parse("50ad6dba-0eb3-46f7-91f4-19ee366e191f");

        //Roles

        public static Guid AdminId { get; set; } = Guid.Parse("9ead58a4-cf4c-494f-b06a-378fbf107618");
        public static Guid StudentId { get; set; } = Guid.Parse("25a5086c-0ee9-4f56-970e-9cb76929cb97");
        public static Guid TeacherId { get; set; } = Guid.Parse("e698be24-5f37-4bfd-bbee-b3e6f1b7abd8");

        //Users

        public static Guid UserOneId { get; set; } = Guid.Parse("65dd12f9-9bd0-4158-bded-c42914c172ff");
        public static Guid UserTwoId { get; set; } = Guid.Parse("351bc69f-b9a0-4220-8a5c-ee52da7420ac");
        public static Guid UserThreeId { get; set; } = Guid.Parse("37ef25be-a859-4c6d-8af6-dc943b430242");

        //Specialitys

        public static Guid PIId { get; set; } = Guid.Parse("7151d40d-03d1-48fa-b9ea-cfe821be254c");
        public static Guid KNId { get; set; } = Guid.Parse("dbf3ccd7-9c27-4bbf-8712-87642ce37b23");
        public static Guid KIUId { get; set; } = Guid.Parse("7282d7f3-4289-4ef2-893c-ea92088c8742");

        //

        public static Guid FirstCourse { get; set; } = Guid.Parse("fc92a0a1-b536-4a98-957e-fbfbabfbbf23");
        public static Guid SecondCourse { get; set; } = Guid.Parse("fa87e685-3997-454c-b83b-8b8e796d6127");
    }
}
