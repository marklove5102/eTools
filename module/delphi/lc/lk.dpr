library lk;
{$IF CompilerVersion >= 21.0}
{$WEAKLINKRTTI ON}
{$RTTI EXPLICIT METHODS([]) PROPERTIES([]) FIELDS([])}
{$IFEND}
{$R *.res}

function LoginCheck(const strName, strPass: PChar): Boolean; stdcall;
begin
  Result := True;
end;

exports
  LoginCheck;

begin

end.
