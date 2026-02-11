const handleCnpj = (event) => {
    let input = event.target
    input.value = formatarCnpj(input.value)
}

function formatarCnpj(cnpj) {
    cnpj = cnpj.replace(/\D/g, ''); // Remove caracteres não numéricos
    cnpj = cnpj.replace(/(\d{3})(\d)/, '$1.$2'); // Adiciona ponto após o terceiro dígito
    cnpj = cnpj.replace(/(\d{3})(\d)/, '$1.$2'); // Adiciona ponto após o sexto dígito
    cnpj = cnpj.replace(/(\d{3})(\d)/, '$1/$2'); // Adiciona ponto após o nono dígito
    cnpj = cnpj.replace(/(\d{4})(\d)/, '$1-$2'); // Adiciona hífen após o decimo terceiro dígito
    cnpj = cnpj.substring(0,19); // Adiciona hífen após o decimo terceiro dígito
    return cnpj;
}