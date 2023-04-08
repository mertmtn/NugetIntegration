using GenericSerializer.Models.Enums;
using GenericSerializer.Models;

string testData = @"<TaskList>
                        <Task>
                            <TaskAdi>Name1</TaskAdi>
                            <Desc>Desc1</Desc>
                        </Task>
                        <Task>
                            <TaskAdi>Name2</TaskAdi>
                            <Desc>Desc2</Desc>
                        </Task>
                    </TaskList>";

var xmlSerializer = GenericSerializer<ToDoList>.
    CreateSerializerObject(DataFormatType.XML);
var task1 = xmlSerializer.DeserializeFromString(testData);

Console.WriteLine(task1.TaskList.FirstOrDefault().TaskAdi);
Console.ReadKey();