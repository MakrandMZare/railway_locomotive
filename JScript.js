function ChangeStyle(str)
    {
    if(str != null)
        {
        var n = document.getElementById(str);
        if(n)
            {
            n.style.backgroundColor="#F5D0A9";
            n.style.border = "solid 1px gray";
            }
        }
    }
    function ChangeDefaultStyle(str)
    {
    if(str != null)
        {
        var n = document.getElementById(str);
        if(n)
            {
            n.style.backgroundColor="";
            n.style.border = "";
            document.body.removeChild(document.getElementById("ctrtooltip"));
            }
        }
    }
    function Check_SelectedIndex(str)
    {
        alert('asdasda');

    return false;

    }
    function Fill_CurrentDate(str)
    {
    if(str != null)
        {
        var n = document.getElementById(str);
        if(n)
            {
            var d1 = new Date();
            n.value = d1.getDay().toString() + "/" + d1.getMonth().toString() + "/" + d1.getFullYear().toString();
            }
        }
    }
   function Validate_selectedIndex(Index,msg)
   {
   if(parseInt(Index) > 0)
    {
        return true;
    }
        alert('Please Select ' + msg);
        return false;
   }
   function IsNull(str,msg)
   {
   if(str == null || str == "")
    {
     alert('Please Select ' + msg);
    return false;
    }
   return true;
   }
   function ConfirmPassword(str1,str2)
   {
    alert(str1 + ' - ' + str2);
    if(str1 != str2)
    {    
       alert('Please Enter Same Password Again...!');
       return false;
    }
    return true;
   }
   function isAlphabetic(keyCode)
       {
       return ((keyCode >= 65 && keyCode <= 90) || keyCode == 32 || keyCode == 8 || keyCode == 9 || (keyCode >= 37 && keyCode <= 40) || keyCode == 46 || keyCode == 16)
       }
     function isNumerical(keyCode)
       {
       return ((keyCode >= 96 && keyCode <= 105) ||(keyCode >= 48 && keyCode <= 57)|| keyCode == 8 || keyCode == 9 || (keyCode >= 37 && keyCode <= 40) || keyCode == 46 || keyCode == 16)
       }