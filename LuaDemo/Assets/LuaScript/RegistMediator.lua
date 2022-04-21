RegistMediator = {}
function RegistMediator.regist()
    local moduleIns = ModuleManager.ins();
    local clsDic = moduleIns.clsDic;
    clsDic[ModuleId.Login] = LoginMediator;
end
return RegistMediator;
