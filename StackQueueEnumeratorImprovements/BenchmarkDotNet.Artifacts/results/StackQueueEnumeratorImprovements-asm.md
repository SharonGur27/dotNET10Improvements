## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.StackDirect()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+14]
       mov       edx,[rcx+10]
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       r10d,edx
       mov       r8d,[r8+r10*4+10]
       add       eax,r8d
M00_L01:
       mov       r8,[rcx+8]
       dec       edx
       mov       r10d,[r8+8]
       cmp       r10d,edx
       ja        short M00_L00
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.QueueDirect()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       rcx,[rcx+10]
       mov       edx,[rcx+1C]
       mov       edx,0FFFFFFFF
M00_L00:
       mov       r8d,[rcx+18]
       inc       edx
       cmp       edx,r8d
       jae       short M00_L02
       mov       r8,[rcx+8]
       mov       r10d,edx
       add       r10d,[rcx+10]
       mov       r9d,[r8+8]
       cmp       r9d,r10d
       jbe       short M00_L03
M00_L01:
       cmp       r10d,r9d
       jae       short M00_L04
       mov       r10d,r10d
       mov       r8d,[r8+r10*4+10]
       add       eax,r8d
       jmp       short M00_L00
M00_L02:
       add       rsp,20
       pop       rbp
       ret
M00_L03:
       sub       r10d,r9d
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 90
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.ConcurrentQueueDirect()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       edx,edx
       xor       r8d,r8d
       mov       rcx,[rcx+18]
       cmp       [rcx],cl
       mov       r10d,0FFFFFFFF
       jmp       short M00_L02
       nop       word ptr [rax+rax]
M00_L00:
       mov       rax,rdx
       test      rax,rax
       je        short M00_L04
M00_L01:
       inc       r10d
       mov       r9d,[rax+8]
       cmp       r9d,r10d
       jbe       short M00_L05
       mov       r9d,r10d
       mov       rax,[rax+r9*8+10]
M00_L02:
       test      rax,rax
       je        short M00_L00
M00_L03:
       mov       r9d,[rax+14]
       mov       rax,[rax+8]
       add       r8d,r9d
       test      rax,rax
       je        short M00_L00
       jmp       short M00_L03
M00_L04:
       mov       rdx,[rcx+8]
       mov       rdx,[rdx+10]
       mov       rax,rdx
       jmp       short M00_L01
M00_L05:
       mov       eax,r8d
       pop       rbp
       ret
; Total bytes of code 100
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.StackDirect()
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-30],rsp
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+14]
       mov       [rbp-20],rcx
       mov       [rbp-18],edx
       mov       dword ptr [rbp-14],0FFFFFFFE
       xor       ecx,ecx
       mov       [rbp-10],ecx
M00_L00:
       mov       ecx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+14]
       jne       near ptr M00_L09
       cmp       dword ptr [rbp-14],0FFFFFFFE
       je        short M00_L03
       cmp       dword ptr [rbp-14],0FFFFFFFF
       je        near ptr M00_L06
       mov       ecx,[rbp-14]
       dec       ecx
       mov       [rbp-14],ecx
       not       ecx
       shr       ecx,1F
       je        short M00_L02
       mov       rdx,[rbp-20]
       mov       rdx,[rdx+8]
       mov       r8d,[rdx+8]
       cmp       [rbp-14],r8d
       jae       short M00_L08
       mov       r8d,[rbp-14]
       mov       edx,[rdx+r8*4+10]
       mov       [rbp-10],edx
M00_L01:
       movzx     ecx,cl
       jmp       short M00_L05
M00_L02:
       xor       edx,edx
       mov       [rbp-10],edx
       jmp       short M00_L01
M00_L03:
       mov       rcx,[rbp-20]
       mov       ecx,[rcx+10]
       dec       ecx
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L04
       mov       rdx,[rbp-20]
       mov       rdx,[rdx+8]
       mov       r8d,[rdx+8]
       cmp       [rbp-14],r8d
       jae       short M00_L08
       mov       r8d,[rbp-14]
       mov       edx,[rdx+r8*4+10]
       mov       [rbp-10],edx
M00_L04:
       movzx     ecx,cl
M00_L05:
       test      ecx,ecx
       je        short M00_L10
       cmp       dword ptr [rbp-14],0
       jl        short M00_L07
       mov       ecx,[rbp-10]
       add       eax,ecx
       jmp       near ptr M00_L00
M00_L06:
       xor       ecx,ecx
       jmp       short M00_L05
M00_L07:
       lea       rcx,[rbp-20]
       call      qword ptr [7FFA0AF15380]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA0AF15368]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA0AE449D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       dword ptr [rbp-14],0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       dword ptr [rbp-14],0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 339
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.QueueDirect()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-20],rsp
       xor       eax,eax
       mov       rcx,[rcx+10]
       mov       edx,[rcx+1C]
       mov       [rbp-18],rcx
       mov       [rbp-10],edx
       mov       dword ptr [rbp-0C],0FFFFFFFF
       xor       ecx,ecx
       mov       [rbp-8],ecx
M00_L00:
       mov       ecx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+1C]
       jne       near ptr M00_L06
       cmp       dword ptr [rbp-0C],0FFFFFFFE
       je        near ptr M00_L07
       mov       ecx,[rbp-0C]
       inc       ecx
       mov       [rbp-0C],ecx
       mov       ecx,[rbp-0C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+18]
       je        short M00_L02
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       edx,[rcx+8]
       mov       r8d,edx
       mov       r10,[rbp-18]
       mov       r10d,[r10+10]
       add       r10d,[rbp-0C]
       cmp       r10d,r8d
       jae       short M00_L03
M00_L01:
       cmp       r10d,edx
       jae       short M00_L05
       mov       r8d,r10d
       mov       r10d,[rcx+r8*4+10]
       mov       [rbp-8],r10d
       cmp       dword ptr [rbp-0C],0
       jl        short M00_L04
       mov       ecx,[rbp-8]
       add       eax,ecx
       jmp       short M00_L00
M00_L02:
       mov       dword ptr [rbp-0C],0FFFFFFFE
       xor       edx,edx
       mov       [rbp-8],edx
       jmp       short M00_L07
M00_L03:
       sub       r10d,r8d
       jmp       short M00_L01
M00_L04:
       lea       rcx,[rbp-18]
       call      qword ptr [7FFA0AEF5440]
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L06:
       call      qword ptr [7FFA0ACD7A50]
       int       3
M00_L07:
       mov       dword ptr [rbp-0C],0FFFFFFFE
       xor       ecx,ecx
       mov       [rbp-8],ecx
       add       rsp,40
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       dword ptr [rbp-0C],0FFFFFFFE
       xor       eax,eax
       mov       [rbp-8],eax
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 261
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.ConcurrentQueueDirect()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       xor       ebx,ebx
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Int32, System.Int32>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       [rbp-28],rdi
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFA0AF2D1A0]; System.Collections.Concurrent.ConcurrentDictionary`2+Enumerator[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L01
       mov       rax,[rdi+28]
       mov       [rbp-20],rax
       add       ebx,[rbp-1C]
       jmp       short M00_L00
M00_L01:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 140
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2+Enumerator[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       mov       rbx,rcx
M01_L00:
       mov       esi,[rbx+24]
       cmp       esi,2
       je        short M01_L02
       cmp       esi,2
       ja        near ptr M01_L03
       mov       ecx,esi
       lea       rdx,[7FFA0AB3C710]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+20],0FFFFFFFF
M01_L01:
       mov       rcx,[rbx+10]
       mov       edx,[rbx+20]
       inc       edx
       mov       [rbx+20],edx
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M01_L03
       mov       edx,edx
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+24],2
M01_L02:
       mov       rsi,[rbx+18]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       mov       edx,[rsi+14]
       mov       [rbx+28],ecx
       mov       [rbx+2C],edx
       mov       rdx,[rsi+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       dword ptr [rbx+24],3
       xor       eax,eax
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 170
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.StackDirect()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+14]
       mov       edx,[rcx+10]
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       r10d,edx
       mov       r8d,[r8+r10*4+10]
       add       eax,r8d
M00_L01:
       mov       r8,[rcx+8]
       dec       edx
       mov       r10d,[r8+8]
       cmp       r10d,edx
       ja        short M00_L00
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.QueueDirect()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       rcx,[rcx+10]
       mov       edx,[rcx+1C]
       mov       edx,0FFFFFFFF
       mov       r8d,[rcx+18]
       inc       edx
       cmp       edx,r8d
       jae       short M00_L02
M00_L00:
       mov       r8,[rcx+8]
       mov       r10d,edx
       add       r10d,[rcx+10]
       mov       r9d,[r8+8]
       cmp       r9d,r10d
       jbe       short M00_L03
M00_L01:
       cmp       r10d,r9d
       jae       short M00_L04
       mov       r10d,r10d
       mov       r8d,[r8+r10*4+10]
       add       eax,r8d
       mov       r8d,[rcx+18]
       inc       edx
       cmp       edx,r8d
       jb        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbp
       ret
M00_L03:
       sub       r10d,r9d
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 99
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.ConcurrentQueueDirect()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       edx,edx
       xor       r8d,r8d
       mov       rcx,[rcx+18]
       cmp       [rcx],cl
       mov       r10d,0FFFFFFFF
       jmp       short M00_L03
       nop       dword ptr [rax]
M00_L00:
       mov       r9d,[rax+14]
       mov       rax,[rax+8]
       add       r8d,r9d
       test      rax,rax
       jne       short M00_L00
M00_L01:
       mov       rax,rdx
       test      rax,rax
       je        short M00_L04
M00_L02:
       inc       r10d
       mov       r9d,[rax+8]
       cmp       r9d,r10d
       jbe       short M00_L05
       mov       r9d,r10d
       mov       rax,[rax+r9*8+10]
M00_L03:
       test      rax,rax
       je        short M00_L01
       jmp       short M00_L00
M00_L04:
       mov       rdx,[rcx+8]
       mov       rdx,[rdx+10]
       mov       rax,rdx
       jmp       short M00_L02
M00_L05:
       mov       eax,r8d
       pop       rbp
       ret
; Total bytes of code 101
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.StackDirect()
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-30],rsp
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+14]
       mov       [rbp-20],rcx
       mov       [rbp-18],edx
       mov       dword ptr [rbp-14],0FFFFFFFE
       xor       ecx,ecx
       mov       [rbp-10],ecx
M00_L00:
       mov       ecx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       ecx,[rdx+14]
       jne       near ptr M00_L09
       cmp       dword ptr [rbp-14],0FFFFFFFE
       je        short M00_L01
       cmp       dword ptr [rbp-14],0FFFFFFFF
       je        near ptr M00_L06
       mov       ecx,[rbp-14]
       dec       ecx
       mov       [rbp-14],ecx
       not       ecx
       shr       ecx,1F
       je        short M00_L04
       mov       rdx,[rbp-20]
       mov       rdx,[rdx+8]
       mov       r8d,[rdx+8]
       cmp       [rbp-14],r8d
       jae       short M00_L08
       mov       r8d,[rbp-14]
       mov       edx,[rdx+r8*4+10]
       mov       [rbp-10],edx
       jmp       short M00_L05
M00_L01:
       mov       rcx,[rbp-20]
       mov       ecx,[rcx+10]
       dec       ecx
       mov       [rbp-14],ecx
       cmp       dword ptr [rbp-14],0
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L02
       mov       rdx,[rbp-20]
       mov       rdx,[rdx+8]
       mov       r8d,[rdx+8]
       cmp       [rbp-14],r8d
       jae       short M00_L08
       mov       r8d,[rbp-14]
       mov       edx,[rdx+r8*4+10]
       mov       [rbp-10],edx
M00_L02:
       movzx     ecx,cl
M00_L03:
       test      ecx,ecx
       je        short M00_L10
       cmp       dword ptr [rbp-14],0
       jl        short M00_L07
       mov       ecx,[rbp-10]
       add       eax,ecx
       jmp       near ptr M00_L00
M00_L04:
       xor       edx,edx
       mov       [rbp-10],edx
M00_L05:
       movzx     ecx,cl
       jmp       short M00_L03
M00_L06:
       xor       ecx,ecx
       jmp       short M00_L03
M00_L07:
       lea       rcx,[rbp-20]
       call      qword ptr [7FFA0AF15458]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA0AF15440]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA0AE449D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       dword ptr [rbp-14],0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       dword ptr [rbp-14],0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 339
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.QueueDirect()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-20],rsp
       xor       eax,eax
       mov       rcx,[rcx+10]
       mov       edx,[rcx+1C]
       mov       [rbp-18],rcx
       mov       [rbp-10],edx
       mov       dword ptr [rbp-0C],0FFFFFFFF
       xor       ecx,ecx
       mov       [rbp-8],ecx
M00_L00:
       mov       ecx,[rbp-10]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+1C]
       jne       near ptr M00_L06
       cmp       dword ptr [rbp-0C],0FFFFFFFE
       je        near ptr M00_L07
       mov       ecx,[rbp-0C]
       inc       ecx
       mov       [rbp-0C],ecx
       mov       ecx,[rbp-0C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+18]
       je        short M00_L04
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       edx,[rcx+8]
       mov       r8d,edx
       mov       r10,[rbp-18]
       mov       r10d,[r10+10]
       add       r10d,[rbp-0C]
       cmp       r10d,r8d
       jae       short M00_L02
M00_L01:
       cmp       r10d,edx
       jae       short M00_L05
       mov       r8d,r10d
       mov       r10d,[rcx+r8*4+10]
       mov       [rbp-8],r10d
       cmp       dword ptr [rbp-0C],0
       jl        short M00_L03
       mov       ecx,[rbp-8]
       add       eax,ecx
       jmp       short M00_L00
M00_L02:
       sub       r10d,r8d
       jmp       short M00_L01
M00_L03:
       lea       rcx,[rbp-18]
       call      qword ptr [7FFA0AEF5440]
       int       3
M00_L04:
       mov       dword ptr [rbp-0C],0FFFFFFFE
       xor       ecx,ecx
       mov       [rbp-8],ecx
       jmp       short M00_L07
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L06:
       call      qword ptr [7FFA0ACD7A50]
       int       3
M00_L07:
       mov       dword ptr [rbp-0C],0FFFFFFFE
       xor       ecx,ecx
       mov       [rbp-8],ecx
       add       rsp,40
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       dword ptr [rbp-0C],0FFFFFFFE
       xor       eax,eax
       mov       [rbp-8],eax
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 261
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; StackQueueEnumeratorImprovements.ConcurrentQueueDirect()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       xor       ebx,ebx
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Int32, System.Int32>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       [rbp-28],rdi
M00_L00:
       mov       rcx,rdi
       call      qword ptr [7FFA0AF01350]; System.Collections.Concurrent.ConcurrentDictionary`2+Enumerator[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L01
       mov       rax,[rdi+28]
       mov       [rbp-20],rax
       add       ebx,[rbp-1C]
       jmp       short M00_L00
M00_L01:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 140
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2+Enumerator[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       mov       rbx,rcx
M01_L00:
       mov       esi,[rbx+24]
       cmp       esi,2
       je        short M01_L02
       jmp       short M01_L04
M01_L01:
       mov       rcx,[rbx+10]
       mov       edx,[rbx+20]
       inc       edx
       mov       [rbx+20],edx
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       short M01_L03
       mov       edx,edx
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+24],2
M01_L02:
       mov       rsi,[rbx+18]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       mov       edx,[rsi+14]
       mov       [rbx+28],ecx
       mov       [rbx+2C],edx
       mov       rdx,[rsi+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       dword ptr [rbx+24],3
       xor       eax,eax
       pop       rbx
       pop       rsi
       ret
M01_L04:
       cmp       esi,2
       ja        short M01_L03
       mov       ecx,esi
       lea       rdx,[7FFA0AB0C510]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rdx,[rcx+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+20],0FFFFFFFF
       jmp       near ptr M01_L01
; Total bytes of code 173
```

