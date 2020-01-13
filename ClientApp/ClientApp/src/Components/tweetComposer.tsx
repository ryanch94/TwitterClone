import React from 'react'
import { Button, Form } from 'reactstrap'
import { IUser, ITweet } from '../App'

interface IProps {
    createTweet: any
}

export const TweetComposer: React.FC<IProps> = ({ createTweet }) => {
    return (
        <div className="tweet-composer">
            <Form>
                <textarea className="form-control" maxLength={140} id="tweetEntry"></textarea>
                <Button color="primary" onClick={(e) => {
                    createTweet();
                }}>Tweet</Button>
            </Form>
        </div>
    );
}