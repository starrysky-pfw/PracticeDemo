#定义对象
class PythonClassOne():
    def SayHello(self):  #这里一定要self参数 不然在调用时会出错
        print("Hello 你们好啊！")
    
        
    def Introduce(self,name):
        print("我的名字叫：" + str(name))



#调用对象 不带参数和带参数的2种调用方法
classone = PythonClassOne()
classone.SayHello()
classone.Introduce('StarrySky')

