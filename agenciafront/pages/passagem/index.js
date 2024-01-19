import axios from 'axios';
import Link from 'next/link';
import React, { useEffect, useState } from 'react'


export default function index() {
    const [passagens, setPassagens] = useState([]);

    useEffect(() => {
        // Faça uma chamada GET para a API Spring Boot
        axios
            .get("https://localhost:7049/passagens")
            .then((response) => {
                setPassagens(response.data);
            })
            .catch((error) => {
                console.error("Erro ao buscar a lista de Passagens:", error);
            });
    }, []);
    return (
        <div className="container-fluid opacity">
            
            <table className="table table-responsive table-hover">
                <thead className="table-dark">
                    <tr className="text-center">
                        <th scope="col">Id</th>
                        <th scope="col">Pacote Promocional</th>
                        <th scope="col">Data de Viagem</th>
                        <th scope="col">Usuario</th>
                        <th scope="col">Destino</th>
                        <th scope="col">Valor</th>
                    </tr>
                </thead>
                <tbody>
                    {passagens.map((passagem)=>(
                    <tr className="text-center">
                        <th scope="row">
                            {passagem.id}
                        </th>
                        <td>
                            {passagem.pacotePromo}
                        </td>
                        <td>
                            {passagem.dataViagem}
                        </td>
                        <td>
                            {passagem.usuario.nome}
                        </td>
                        <td>
                            {passagem.destino.cidade}
                        </td>
                        <td>
                           <span className='fw-bold'>R$</span> {passagem.valorTotal}
                        </td>
                        
                    </tr>
                    ))}
                </tbody>
            </table>
        </div>

    )
}
