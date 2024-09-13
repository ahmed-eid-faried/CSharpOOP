using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Employee13
    {
        public string name;
    }

    struct Employee14
    {
        public string name;
    }
    internal class ClassAndStruct
    {
        //إليك جدول يقارن بين الكلاس(Class) والهيكل(Struct) في لغة #C:

        //الخاصية Class(الكلاس)  Struct(الهيكل)
        //نوع البيانات           نوع مرجعي(Reference Type)          نوع قيمة(Value Type)
        //التخزين في الذاكرة يُخزن في الذاكرة المؤقتة(Heap) يُخزن في المكدس(Stack)
        //النسخ عند النسخ، يتم نسخ المرجع فقط(أي التغييرات تؤثر على الكائن الأصلي) عند النسخ، يتم نسخ القيمة بالكامل(لا تؤثر التغييرات على النسخة الأصلية)
        //الوراثة(Inheritance)   يدعم الوراثة(يمكن للكلاس أن يرث من كلاس آخر)   لا يدعم الوراثة(لا يمكن للهيكل أن يرث من هيكل أو كلاس آخر)
        //المُنشئ الافتراضي   يحتوي على مُنشئ افتراضي يُضاف تلقائيًا  لا يحتوي على مُنشئ افتراضي، ويجب تعيين جميع الحقول يدويًا
        //الأداء  أبطأ نسبيًا، خاصة مع الأنواع الصغيرة، نظرًا لتخزينه في الذاكرة المؤقتة أسرع نسبيًا عند التعامل مع الأنواع الصغيرة والبسيطة، نظرًا لتخزينه في المكدس
        //إدارة الذاكرة   يستهلك مساحة أكبر في الذاكرة المؤقتة، ولكن مع مرونة أكبر    يُستهلك في المكدس، والذي يعد محدود الحجم
        //قابلية التعديل  يمكن تعديل البيانات عبر المرجع كل عملية نسخ تنتج نسخة مستقلة
        //الدعم للأساليب والخصائص يمكن أن يحتوي على أساليب، خصائص، أحداث، ووظائف معقدة    يمكن أن يحتوي على أساليب وخصائص ولكنه بسيط نسبيًا
        //استخدامات   يُستخدم للأشياء الكبيرة والمعقدة التي تحتاج إلى مرجع متكرر يُستخدم للبيانات البسيطة والخفيفة مثل الأنواع العددية


        public void ClassEx()
        {
            Employee13 emp1 = new Employee13();
            emp1.name = "John";
            Employee13 emp2 = emp1;
            emp2.name = "Ahmed Mady";
            Console.WriteLine("Employee1 name: " + emp1.name); // النتيجة: Ahmed Mady
        }
        public void StructEx()
        {
            Employee14 emp1 = new Employee14();
            emp1.name = "Ahmed Mady";
            Employee14 emp2 = emp1;
            emp2.name = "Ali";
            Console.WriteLine("Employee1 name: " + emp1.name); // النتيجة: Ahmed Mady
        }
    }
}
