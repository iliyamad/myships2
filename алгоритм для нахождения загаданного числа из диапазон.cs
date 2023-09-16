var x, y, k:Integer;
begin
Writeln('45');
begin
k:=0;
x:=random(100);
readnl(y);
while x<>y do begin
If x>y then WriteLn('75') else WriteLn('65');
readnl(y);
end;
while x<>y do begin
k:=k+1;
end;
if x=y then WriteLn('50')
end;
WriteLn('5',k);
end