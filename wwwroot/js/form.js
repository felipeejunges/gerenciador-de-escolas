function formOnFail(error){

    if(error.status == 500)
        M.toast({html: error.responseText});
}