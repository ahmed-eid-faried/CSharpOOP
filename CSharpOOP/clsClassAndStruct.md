 الفرق بين Class و Struct في C#
==============================

في C#، هناك فرق بين **الكلاس (Class)** و**الهيكل (Struct)**. بينما يمكن أن يبدو الكلاس والهيكل متشابهين في البداية، إلا أن هناك اختلافات أساسية بينهما.

1\. نوع البيانات (Reference Type vs Value Type)
-----------------------------------------------

**الكلاس (Class)** هو نوع مرجعي (Reference Type)، وهذا يعني أن عند نسخ كائن من الكلاس، يتم نسخ المرجع فقط. أي تغييرات على المرجع تؤثر على الكائن الأصلي.

**الهيكل (Struct)** هو نوع قيمة (Value Type)، وهذا يعني أن عند نسخ هيكل، يتم نسخ القيمة بالكامل. التغييرات على النسخة الجديدة لا تؤثر على النسخة الأصلية.

مثال على الكلاس
---------------

    using System;
    
    namespace CsharpStruct {
        class Employee {
            public string name;
        }
    
        class Program {
            static void Main(string[] args) {
                Employee emp1 = new Employee();
                emp1.name = "John";
    
                Employee emp2 = emp1;
                emp2.name = "Mohammed";
                Console.WriteLine("Employee1 name: " + emp1.name);
    
                Console.ReadLine();
            }
        }
    }
            

**النتيجة:**  
Employee1 name: Mohammed

مثال على الهيكل
---------------

    using System;
    
    namespace CsharpStruct {
        struct Employee {
            public string name;
        }
    
        class Program {
            static void Main(string[] args) {
                Employee emp1 = new Employee();
                emp1.name = "Mohammed";
    
                Employee emp2 = emp1;
                emp2.name = "Ali";
                Console.WriteLine("Employee1 name: " + emp1.name);
    
                Console.ReadLine();
            }
        }
    }
            

**النتيجة:**  
Employee1 name: Mohammed

2\. الوراثة (Inheritance)
-------------------------

**الكلاس (Class)** يمكنه دعم الوراثة، وهذا يعني أن كلاس يمكن أن يرث من كلاس آخر.

**الهيكل (Struct)** لا يدعم الوراثة، فلا يمكن لهيكل أن يرث من هيكل أو كلاس آخر.

3\. المُنشئ الافتراضي (Default Constructor)
-------------------------------------------

**الكلاس (Class)** يحتوي على منشئ افتراضي يُضاف تلقائيًا إذا لم يتم تعريفه.  
**الهيكل (Struct)** لا يحتوي على منشئ افتراضي، ويجب تعيين القيم يدويًا.

4\. الأداء وإدارة الذاكرة
-------------------------

**الكلاس (Class)** يُخزن في الذاكرة المؤقتة (Heap)، مما يوفر مرونة في إدارة الذاكرة ولكنه قد يكون أبطأ في بعض الحالات.

**الهيكل (Struct)** يُخزن في المكدس (Stack)، مما يجعله أسرع عند استخدام أنواع بيانات صغيرة وبسيطة، ولكن الذاكرة محدودة.

الخلاصة
-------

يختلف استخدام الكلاس والهيكل حسب متطلبات البرنامج. إذا كنت بحاجة إلى نوع مرجعي يدعم الوراثة ويستخدم في الذاكرة المؤقتة، فإن الكلاس هو الخيار المناسب. أما إذا كنت بحاجة إلى نوع بسيط وقيمته ثابتة عند النسخ، فإن الهيكل هو الخيار الأفضل.