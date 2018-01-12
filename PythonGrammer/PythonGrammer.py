#python中注意事项
#1.#表示注释；\n表示换行
#2.引用外界包与java一样 使用import
import math
import PythonFunction
print("--Python学习之旅--")

##
#BIF:内置函数
##

#转换函数
print("\n转换函数")
print(int('3'))
print(str(1))
print(float(3))

#算数操作符 (+ - * / // **)
#1.操作符运算顺序:无括号先乘除和加减 有括号按照括号顺序执行 2.python中的/是精确计算;若要求整数部分用// 2.**指幂
print("\n算数操作符 (+ - * / // **)")
a = b = c = 100   #批量多参数赋值
print(a)
a+=20
print(a)
print(b)
print(c)
print(1 + 2)
print(10 - 1)
print(10 * 2)
print(10 / 2.5) 
print(10 // 2.5) 
print(10 ** 2)
print(100 + 2 - 1 * 10 / 2)

#字符串
name = 'starry sky'
print(name.title())   #将字符串中的英文单词 首字母变为大写
print(name.upper())


#for循环
print("\nfor循环")
for x in [10,20,30]:
    print(x)

#判断条件语句
print("\n判断条件语句")
inputNum = input("if判断语句测试。请输入一个数字：")
if int(inputNum) > 10:  #这里如果直接写 if inputNum > 10 会出错 必须将输入值inputNum转换为int后才能比较
    print("输入值大于10")
else:
    if int(inputNum) > 5:
        print("输入值大于5小于10")
    else:
        if int(inputNum) > 0:
            print("输入值大于0小于5")

if int(inputNum) > 10:
    print("输入值大于10")
elif int(inputNum) > 5:
    print("输入值大于5小于10")
elif int(inputNum) > 0:
    print("输入值大于0小于5")

#三元操作符
print("\n三元操作符")
x,y = 4,5  
if x < y:
    small = x
else :
    small = y
small = x if x < y else y  #三元运算符改造
print(small)

#assert 断言 主要是在调试中抛出异常 例如：3 > 4 结果为false ; assert 3 > 4 则会抛出异常
print("\nassert断言")
rst = 3 > 4
print(rst)

#列表 添加元素：append/extend/insert 获取元素 移除元素：remove/del/pop[默认删除最后一个值]
stu = ['张三',12,['打篮球','打排球']]
print(stu)
stu.append('李四')
print(stu)
stu.extend(['王麻子','王五'])
print(stu)
stu.insert(0,'潘帅')
print(stu)

#获取元素值
print(stu[1])  

#移除元素
stu.remove('李四')
print(stu)
del stu[0]
stu.pop()
stu.pop(0)
tmp = stu.pop(0)
print(tmp)

 #列表分片 语法:数组[索引:索引] 一次性获取多个元素 [:]:获取数据全部元素
a = stu[2:3]
print(a)
b = stu[:3]
print(b)
c = stu[:]
print(c)


#列表中的操作符
print("\n列表中的操作符")
lista = [123]
listb = [456]
print(lista > listb)

list1 = [123,456]
list2 = [234,342]
print(list1 > list2)

list4 = list1 + list2  #例如list1.append(list2) 不建议使用+
print(list4)
list5 = list1 * 3
print(123 in list1)
list6 = [123,['abc','def'],345,34,101]
print('abc' in list6)   #返回false 因为在数组里面一层 不能访问
print('abc' in list6[1])    #返回true

#列表中内置函数
print("\n列表中内置函数")
print(list6.count(123))  #计算123在数组里面出现了多少次
print(list6.index(345)) #计算345在数组中出现第一次的索引值 可指定从哪个位置开始查找：list6.index(345,1,3)
list7 = [12,2,8,23,65,1]
list7.reverse() #将数组中的数据倒转
print(list7)
list7.sort()  #将数据按照升序排序
print(list7)
list7.sort(reverse=True)  #将数据按照升序排序
print(list7)

#元组 tuple 两种写法 元素之间用逗号相隔离
print("\n元组学习")
tuplea = (1,2,3)
tupleb = 1,2,3
print(tuplea)
print(tupleb)
print(type(tuplea))
print(type(tupleb))
del(tuplea) #删除元组

#python 函数定义
PythonFunction.fun1()


#python lambda表达式
print("\nPython中lambda学习")
def ds(x):
    print(2 * x + 1)
ds(5)  #函数调用
lambda x:x * 5 + 1  #使用lambda 实现上面函数 冒号前面是参数 冒号后面是返回值
g = lambda x:x * 5 + 1
print(g(2))  #lambda表达式单参数调用
def add(x,y):
    print(x + y)
add(1 ,2)
g = lambda x,y:x + y   #lambda表达式多参数调用
print(g(1,5))

#python 过滤器 filter 语法：filter(function or None, iterable) --> filter object
#filter【原理：第一个参数可以为一个函数或者None,第二个参数为迭代器，将第二个参数列表传入第一个参数的函数中 得到返回值为true的列表】
#1.python filter None参数
filter(None,[1,0,False,True])
print(list(filter(None,[1,0,False,True])))

#2.python filter function参数 得到奇数的过滤器
def odd(x):
    return x % 2 
show = filter(odd,range(10))
print(list(show))

show = list(filter(lambda x:x % 2,range(10)))  #使用lambda实现上面的filter过滤函数
print(show)

#python map映射 内置 函数 语法：map(func, *iterables) --> map object
#map【原理：使用iterables中的值依次传递到func中 最后返回一个数组】
show = list(map(lambda x:x * 2 ,range(10))) 
print(show)

#使用easygui
import easygui as g
g.msgbox('这里是内容主体','提示','确定')
