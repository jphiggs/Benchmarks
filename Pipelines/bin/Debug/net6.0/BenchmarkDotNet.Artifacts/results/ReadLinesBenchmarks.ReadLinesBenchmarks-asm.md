## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

## 
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks.ReadLineUsingStringReaderAsync()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       mov       rbp,rsp
       xor       eax,eax
       mov       [rbp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+70],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M00_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M00_L00:
       mov       rcx,offset MT_ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+40],rax
       mov       rcx,[rbp+40]
       call      ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       mov       rcx,[rbp+40]
       mov       [rbp+48],rcx
       mov       rcx,[rbp+48]
       mov       [rbp+38],rcx
       mov       rcx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       mov       [rbp+30],rax
       mov       rax,[rbp+38]
       lea       rdi,[rax+38]
       lea       rsi,[rbp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       dword ptr [rcx+30],0FFFFFFFF
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       r8,[rbp+48]
       lea       rcx,[r8+38]
       lea       r8,[rbp+48]
       mov       rdx,offset MD_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start(!!0 ByRef)
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rcx,[rbp+48]
       cmp       [rcx],ecx
       mov       rdx,[rbp+48]
       lea       rcx,[rdx+38]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.String, System.Private.CoreLib]]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       mov       [rbp+28],rax
       mov       rax,[rbp+28]
       lea       rsp,[rbp+50]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 234
```
```assembly
; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter`1[[System.__Canon, System.Private.CoreLib]].GetResult()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M02_L01
M02_L00:
       mov       rax,[rsi]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      qword ptr [7FFFA65E1510]
       jmp       short M02_L00
; Total bytes of code 47
```
```assembly
; ReadLinesBenchmarks.ReadLinesBenchmarks+<ReadLineUsingStringReaderAsync>d__16..ctor()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,20
       mov       rbp,rsp
       mov       [rbp+40],rcx
       cmp       dword ptr [7FFF4763AD28],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+40]
       call      System.Object..ctor()
       nop
       nop
       lea       rsp,[rbp+20]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].Start[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,r8
       mov       rcx,rdx
       call      qword ptr [7FFFA6654188]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFFA665A2B0]
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Task()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rax,[rsi]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,30
       pop       rsi
       ret
M06_L01:
       mov       rcx,rdx
       call      qword ptr [7FFFA65E52A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFFA65D7930]
       jmp       short M06_L00
; Total bytes of code 50
```
```assembly
; Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFFA6650530]
       mov       [rbp],rax
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r15d,[rbp+90]
       mov       r14,[rbp+98]
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+18],rcx
       mov       dword ptr [rbp+20],100
       mov       r12,[rbp+18]
       mov       r13d,[rbp+20]
       mov       rax,rsi
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rax+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M07_L05
       mov       [rbp+18],r12
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L00
       call      qword ptr [7FFFA6650580]
M07_L00:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L01:
       cmp       eax,2
       jne       near ptr M07_L03
       mov       ecx,500
       call      qword ptr [7FFFA66579B8]
       add       rax,10
       mov       r12,rax
       mov       r13d,500
       mov       [rbp+8],r12
       mov       [rbp+10],r13d
       mov       [rsp+20],r15d
       mov       rcx,[rsi+8]
       lea       rdx,[rbp+8]
       movzx     r9d,bx
       mov       r8,rdi
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M07_L03
       mov       rcx,r12
       xor       edx,edx
       mov       r8d,r13d
       call      qword ptr [7FFFA665CDD0]
       mov       ecx,eax
       mov       edx,r13d
       cmp       rcx,rdx
       ja        short M07_L05
       mov       rcx,r12
       mov       [rbp+18],rcx
       mov       [rbp+20],eax
       lea       rcx,[rbp+18]
       call      qword ptr [7FFFA6655160]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFFA6650590]
       mov       eax,1
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L02
       call      qword ptr [7FFFA6650580]
M07_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       xor       eax,eax
       mov       [r14],rax
       lea       rcx,[7FFFA6650530]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M07_L04
       call      qword ptr [7FFFA6650580]
M07_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       call      qword ptr [7FFFA665CFB8]
       int       3
; Total bytes of code 467
```

