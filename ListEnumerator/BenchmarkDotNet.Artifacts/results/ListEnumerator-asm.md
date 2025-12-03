## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; ListEnumerator.ForeachDirect()
       sub       rsp,28
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+14]
       xor       edx,edx
       cmp       edx,[rcx+10]
       jae       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L00:
       mov       r8,[rcx+8]
       cmp       edx,[r8+8]
       jae       short M00_L02
       mov       r8d,[r8+rdx*4+10]
       inc       edx
       add       eax,r8d
       cmp       edx,[rcx+10]
       jb        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 68
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; ListEnumerator.ForeachDirect()
       sub       rsp,28
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+14]
       xor       edx,edx
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L00:
       mov       r8,[rcx+8]
       cmp       edx,[r8+8]
       jae       short M00_L02
       mov       r8d,[r8+rdx*4+10]
       inc       edx
       add       eax,r8d
M00_L01:
       cmp       edx,[rcx+10]
       jb        short M00_L00
       add       rsp,28
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 68
```

## .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
```assembly
; ListEnumerator.ForeachViaInterface()
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       ebx,ebx
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rcx],rax
       jne       short M00_L04
       mov       eax,[rcx+10]
       test      eax,eax
       je        short M00_L03
       mov       edx,[rcx+14]
       xor       r8d,r8d
       cmp       edx,[rcx+14]
       jne       short M00_L01
M00_L00:
       cmp       r8d,eax
       jae       short M00_L02
       mov       r10,[rcx+8]
       cmp       r8d,[r10+8]
       jae       near ptr M00_L08
       mov       r10d,[r10+r8*4+10]
       inc       r8d
       add       ebx,r10d
       cmp       edx,[rcx+14]
       je        short M00_L00
M00_L01:
       call      qword ptr [7FF9D3C9C0D8]
       int       3
M00_L02:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.Int32>
       call      qword ptr [7FF9D3A15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A46A001488
       mov       rcx,[rcx]
       jmp       short M00_L05
M00_L04:
       mov       r11,7FF9D3960520
       call      qword ptr [r11]
       mov       rcx,rax
M00_L05:
       mov       [rbp-10],rcx
M00_L06:
       mov       rcx,[rbp-10]
       mov       r11,[rcx]
       mov       r11,7FF9D3960528
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rcx,[rbp-10]
       mov       r11,7FF9D3960530
       call      qword ptr [r11]
       add       eax,ebx
       mov       ebx,eax
       jmp       short M00_L06
M00_L07:
       mov       rcx,[rbp-10]
       mov       r11,7FF9D3960538
       call      qword ptr [r11]
       jmp       short M00_L02
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-10],0
       je        short M00_L09
       mov       rcx,[rbp-10]
       mov       r11,7FF9D3960538
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 258
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M01_L00
       ret
M01_L00:
       jmp       qword ptr [7FF9D3A15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 9.0.11 (9.0.1125.51716), X64 RyuJIT AVX2
```assembly
; ListEnumerator.ForeachViaInterface()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       xor       ebx,ebx
       mov       rsi,[rcx+10]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       cmp       [rsi],rcx
       jne       near ptr M00_L09
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L08
       mov       rdi,offset MT_System.Collections.Generic.List<System.Int32>+Enumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       esi,[rdx+14]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],ecx
       mov       [rdi+14],esi
       mov       [rdi+18],ecx
M00_L00:
       mov       [rbp-30],rdi
M00_L01:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>+Enumerator
       mov       r14,rcx
       cmp       rsi,r14
       jne       short M00_L05
       lea       rcx,[rdi+8]
       mov       rax,[rcx]
       mov       edx,[rcx+0C]
       cmp       edx,[rax+14]
       jne       short M00_L04
       mov       edx,[rcx+8]
       cmp       edx,[rax+10]
       jae       short M00_L04
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       short M00_L07
       mov       eax,[rax+rdx*4+10]
       mov       [rcx+10],eax
       inc       dword ptr [rcx+8]
M00_L02:
       mov       r15d,[rdi+18]
M00_L03:
       add       ebx,r15d
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFA0AF17060]; System.Collections.Generic.List`1+Enumerator[[System.Int32, System.Private.CoreLib]].MoveNextRare()
       jmp       short M00_L06
M00_L05:
       mov       rcx,rdi
       mov       r11,7FFA0A9E0528
       call      qword ptr [r11]
M00_L06:
       test      eax,eax
       je        short M00_L10
       cmp       rsi,r14
       je        short M00_L02
       mov       rcx,rdi
       mov       r11,7FFA0A9E0530
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       short M00_L03
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L08:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.Int32>
       call      CORINFO_HELP_GET_GCSTATIC_BASE
       mov       rcx,22A10801498
       mov       rdi,[rcx]
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       mov       r11,7FFA0A9E0520
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,rdi
       mov       r11,7FFA0A9E0538
       call      qword ptr [r11]
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-30],0
       je        short M00_L11
       mov       rcx,[rbp-30]
       mov       r11,7FFA0A9E0538
       call      qword ptr [r11]
M00_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.Int32, System.Private.CoreLib]].MoveNextRare()
       sub       rsp,28
       mov       eax,[rcx+0C]
       mov       rdx,[rcx]
       cmp       eax,[rdx+14]
       jne       short M01_L00
       mov       eax,[rdx+10]
       inc       eax
       mov       [rcx+8],eax
       xor       eax,eax
       mov       [rcx+10],eax
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FFA0ACF7A50]
       int       3
; Total bytes of code 40
```

