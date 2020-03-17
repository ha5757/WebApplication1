function addemp()
{
    var en = document.getElementById("txtempno").value;
    var name = document.getElementById("txtename").value;
    var j = document.getElementById("txtjob").value;
    var sa = document.getElementById("txtsal").value;
    var cm = document.getElementById("txtcomm").value;
    var m = document.getElementById("txtmgr").value;
    var dp = document.getElementById("txtdeptno").value;
    var hd = document.getElementById("txthiredate").value;
    if (en.length == 0 || name.length == 0 || j.length == 0 || sa.length == 0 || cm.length == 0 || m.length == 0 || dp.length == 0 || hd.length == 0 )
    {
        alert("enter all fields");
        return false;
    }
    else
        return true;
}