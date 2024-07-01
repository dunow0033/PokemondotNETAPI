import React from "react";
import List from "@mui/material/List";
import ListItem from "@mui/material/ListItem";
import { ListItemText } from "@mui/material";
import Link from '@mui/material/Link';

function PokemonList({pokemonList}) {

    const listText = {
        color: "white"
    };

    return (
        <div className="pokemon-list-container">
            <List dense={true}>
                {
                    pokemonList.map(pokemon => {
                        return (
                            <ListItem key={pokemon.id}>
                                <Link href={`/pokemon/${pokemon.id}`} underline="hover">
                                    <ListItemText
                                        primary={pokemon.name}
                                    />
                                </Link>
                            </ListItem>
                        )
                    })
                }
            </List>
        </div>
    )
}

export default PokemonList;

