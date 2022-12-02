using System;
using Xunit;
//tests Faker.Datatype class

namespace FakerTest.Datatype
{
    public class DatatypeTest
    {
        [Fact]
        public void IntTest()
        {
            var int1 = Faker.Datatype.Int();
            var int2 = Faker.Datatype.Int();
            var int3 = Faker.Datatype.Int();
            Assert.True(int1 >= 1 && int1 <= 2147483647);
            Assert.True(int2 >= 1 && int2 <= 2147483647);
            Assert.True(int3 >= 1 && int3 <= 2147483647);
        }
        [Fact]
        public void IntTestWithMinAndMax()
        {
            var int1 = Faker.Datatype.Int(1, 10);
            var int2 = Faker.Datatype.Int(1, 10);
            var int3 = Faker.Datatype.Int(1, 10);
            Assert.True(int1 >= 1 && int1 <= 10);
            Assert.True(int2 >= 1 && int2 <= 10);
            Assert.True(int3 >= 1 && int3 <= 10);
        }
        [Fact]
        public void DoubleTest()
        {
            var double1 = Faker.Datatype.Double();
            var double2 = Faker.Datatype.Double();
            var double3 = Faker.Datatype.Double();
            Assert.True(double1 >= 0.1 && double1 <= 2147483647.9);
            Assert.True(double2 >= 0.1 && double2 <= 2147483647.9);
            Assert.True(double3 >= 0.1 && double3 <= 2147483647.9);
        }
        [Fact]
        public void DoubleTestWithMinAndMax()
        {
            var double1 = Faker.Datatype.Double(1, 10);
            var double2 = Faker.Datatype.Double(1, 10);
            var double3 = Faker.Datatype.Double(1, 10);
            Assert.True(double1 >= 1 && double1 <= 10);
            Assert.True(double2 >= 1 && double2 <= 10);
            Assert.True(double3 >= 1 && double3 <= 10);
        }
        [Fact]
        public void BooleanTest()
        {
            var boolean1 = Faker.Datatype.Boolean();
            var boolean2 = Faker.Datatype.Boolean();
            var boolean3 = Faker.Datatype.Boolean();
            Assert.True(boolean1 == true || boolean1 == false);
            Assert.True(boolean2 == true || boolean2 == false);
            Assert.True(boolean3 == true || boolean3 == false);
        }
        [Fact]
        public void UuidTest()
        {
            var uuid1 = Faker.Datatype.Uuid();
            var uuid2 = Faker.Datatype.Uuid();
            var uuid3 = Faker.Datatype.Uuid();
            Assert.True(uuid1 != uuid2 && uuid1 != uuid3 && uuid2 != uuid3);
        }
        [Fact]
        public void StringTest()
        {
            var string1 = Faker.Datatype.String();
            var string2 = Faker.Datatype.String();
            var string3 = Faker.Datatype.String();
            Assert.True(string1.GetType() == typeof(string));
            Assert.True(string2.GetType() == typeof(string));
            Assert.True(string3.GetType() == typeof(string));
            Assert.True(string1 != string2 && string1 != string3 && string2 != string3);
        }
        [Fact]
        public void StringTestWithLength()
        {
            var string1 = Faker.Datatype.String(10);
            var string2 = Faker.Datatype.String(6);
            var string3 = Faker.Datatype.String(9);
            Assert.True(string1 != string2 && string1 != string3 && string2 != string3);
            Assert.True(string1.Length == 10 && string2.Length == 6 && string3.Length == 9);
        }
        //array test
        [Fact]
        public void ArrayTest()
        {
            var array1 = Faker.Datatype.Array();
            var array2 = Faker.Datatype.Array();
            var array3 = Faker.Datatype.Array();
            Type arrayType1 = array1.GetType();
            Type arrayType2 = array2.GetType();
            Type arrayType3 = array3.GetType();
            Assert.True(arrayType1.IsArray);
            Assert.True(arrayType2.IsArray);
            Assert.True(arrayType3.IsArray);
        }
        [Fact]
        public void ArrayWithLengthTest()
        {
            var array1 = Faker.Datatype.Array(length: 10);
            var array2 = Faker.Datatype.Array(length: 6);
            var array3 = Faker.Datatype.Array(length: 9);
            Assert.True(array1 != array2 && array1 != array3 && array2 != array3);
            Assert.True(array1.Length == 10 && array2.Length == 6 && array3.Length == 9);
        }
        [Fact]
        public void ArrayWithLengthAndTypeTest()
        {
            var array1 = Faker.Datatype.Array(length: 10, type: "int");
            var array2 = Faker.Datatype.Array(length: 6, type: "string");
            var array3 = Faker.Datatype.Array(length: 9, type: "boolean");
            var array4 = Faker.Datatype.Array(length: 10, type: "object");
            var array5 = Faker.Datatype.Array(length: 6, type: "array");
            Assert.True(array1 != array2 && array1 != array3 && array2 != array3 && array1 != array4 && array2 != array4 && array3 != array4 && array1 != array5 && array2 != array5 && array3 != array5 && array4 != array5);
            Assert.True(array1.Length == 10 && array2.Length == 6 && array3.Length == 9 && array4.Length == 10 && array5.Length == 6);
            //todo test the types of the elements of the array

        }
        /*
        //object test
        // todo these are all bad tests.
        [Fact]
        public void ObjectTest()
        {
            var object1 = Faker.Datatype.Object();
            var object2 = Faker.Datatype.Object();
            var object3 = Faker.Datatype.Object();
            Assert.True(object1 != object2 && object1 != object3 && object2 != object3);
        }
        [Fact]
        public void ObjectWithLengthTest()
        {
            var object1 = Faker.Datatype.Object(length: 10);
            var object2 = Faker.Datatype.Object(length: 6);
            var object3 = Faker.Datatype.Object(length: 9);
            Assert.True(object1 != object2 && object1 != object3 && object2 != object3);
        }

        /*
        //json test
        // todo these are all bad tests.
        [Fact]
        public void JsonTest()
        {
            var json1 = Faker.Datatype.Json();
            var json2 = Faker.Datatype.Json();
            var json3 = Faker.Datatype.Json();
            Assert.True(json1 != json2 && json1 != json3 && json2 != json3);
        }
        [Fact]
        public void JsonWithLengthTest()
        {
            var json1 = Faker.Datatype.Json(length: 10);
            var json2 = Faker.Datatype.Json(length: 6);
            var json3 = Faker.Datatype.Json(length: 9);
            Assert.True(json1 != json2 && json1 != json3 && json2 != json3);
        }
        */


    }
}