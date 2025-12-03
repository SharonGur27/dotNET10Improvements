## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; TryCatch.Test(Int32)
       lea       eax,[rdx+1]
       ret
; Total bytes of code 4
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; TryCatch.Test(Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       mov       [rbp-10],rsp
       mov       [rbp+18],edx
       mov       eax,[rbp+18]
       inc       eax
       mov       [rbp+18],eax
M00_L00:
       mov       eax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,1C70067B1E8
       call      qword ptr [7FF9D18E4990]
       lea       rax,[M00_L00]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 81
```

